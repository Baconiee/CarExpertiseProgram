using Microsoft.AspNetCore.Mvc;
using CarExpertise.Models;
using Microsoft.EntityFrameworkCore;
using CarExpertise.Data;
using CarExpertise.Migrations;
using System.Diagnostics;
using System.Linq; // Linq kullanabilmek için gerekli kütüphane
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CarExpertise.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CustomerController(ApplicationDbContext db, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Try()
        {
            int currentUserCompanyId = await GetCurrentUserCompanyId();
            var ekspertizSablonList = await _db.EkspertizSablonTable
                                              .Where(s => s.CompanyId == currentUserCompanyId)
                                              .ToListAsync();
            return View(ekspertizSablonList);
        }

        private async Task<int> GetCurrentUserCompanyId()
        {
            var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var user = await _userManager.FindByIdAsync(userId);
            return user?.CompanyId ?? 0; // Kullanıcı bulunamazsa veya CompanyId null ise 0 döner
        }


        public async Task<IActionResult> Main()
        {
            var companyId = await GetCurrentUserCompanyId();
            var deneme1DataList = _db.Deneme1s.Where(d => d.CompanyId == companyId).ToList();
            var carModelList = _db.CarModelTable.ToList();

            // CombinedList modelini doldurun
            var combinedList = new CombinedList
            {
                Deneme1List = deneme1DataList,
                CarModelList = carModelList
            };

            // CompanyId'yi ViewBag'e ekleyin
            ViewBag.CurrentUserCompanyId = companyId;

            // CombinedList modelini ana sayfaya gönderin
            return View(combinedList);
        }



        [HttpGet("list")]
        public IActionResult DeleteCustomer()
        {
            var modelList = _db.Deneme1s.ToList();
            return Ok(modelList);
        }

        public IActionResult Report()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            // Tüm EkspertizSablon kayıtlarını alıyoruz
            var ekspertizList = _db.EkspertizSablonTable.ToList();

            // View'a gönderiyoruz
            return View(ekspertizList);
        }


        

        [HttpPost]
        public IActionResult DeleteCustomer(int id)
        {
            var customerToDelete = _db.Deneme1s.FirstOrDefault(c => c.Id == id); // Veritabanından ilgili müşteriyi bul
            if (customerToDelete != null)
            {
                // İlgili müşteriyi sil
                _db.Deneme1s.Remove(customerToDelete);
                _db.SaveChanges(); // Değişiklikleri kaydet

                // Deneme2 tablosundan ilgili öğeyi bul
                var associatedItem = _db.Deneme2s.Where(d => d.MusteriId == id).ToList();

                if (associatedItem.Any())
                {
                    // İlgili öğeyi sil
                    _db.Deneme2s.RemoveRange(associatedItem);
                    _db.SaveChanges(); // Değişiklikleri kaydet
                }

                var carTables = _db.CarModelTable.Where(c => c.MusteriId == id).ToList();

                if (carTables.Any())
                {
                    // Tüm eşleşen kayıtları sil
                    _db.CarModelTable.RemoveRange(carTables);
                    _db.SaveChanges();
                }


                return RedirectToAction("Main"); // İşlem başarılıysa başka bir sayfaya yönlendir
            }
            else
            {
                return NotFound(); // Müşteri bulunamadıysa 404 Not Found hatası döndür
            }
        }


        [HttpPost]
        public IActionResult CheckPhoneNumber(string telefon)
        {
            var musteri = _db.Deneme1s.FirstOrDefault(d => d.Telefon == telefon);
            if (musteri != null)
            {
                return Json(new
                {
                    success = true,
                    musteriAd = musteri.MusteriAd,
                    email = musteri.Email,


                });
            }
            else
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddModel(TryVehicle model)
        {
            if (ModelState.IsValid)
            {
                // Veritabanına modeli ekle
                _db.Trys.Add(model);
                await _db.SaveChangesAsync();

                // Ekleme başarılı olduğunda bir yönlendirme yapabilirsiniz
                return RedirectToAction("Try", "Customer");
            }

            // Eğer model geçerli değilse, aynı sayfaya geri dönebilir veya hata mesajlarıyla birlikte gösterebilirsiniz
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SablonEkle(EkspertizSablon sablonModel)
        {
            if (ModelState.IsValid)
            {
                if (sablonModel != null)
                {
                    // Şu anda giriş yapmış kullanıcının Id'sini al
                    var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
                    var user = await _userManager.FindByIdAsync(userId);

                    if (user != null)
                    {
                        // Kullanıcının CompanyId'sini sablonModel'e ata
                        sablonModel.CompanyId = user.CompanyId;
                    }

                    // EkspertizSablonData'yı ekle
                    _db.EkspertizSablonTable.Add(sablonModel);

                    // Değişiklikleri kaydet
                    await _db.SaveChangesAsync();

                    // Yönlendirme işlemi
                    return RedirectToAction("Try");
                }
            }

            return View();
        }



        [HttpGet]
        public IActionResult UpdateTemplate(int updateId)
        {
            var update = _db.EkspertizSablonTable
                            .FirstOrDefault(t => t.Id == updateId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpGet]
        public IActionResult GetUpdateTemplate(int updateId)
        {
            var update = _db.EkspertizSablonTable
                            .FirstOrDefault(t => t.Id == updateId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpGet]
        public IActionResult GetExpertise(int expertiseId)
        {
            var update = _db.Deneme2s
                            .FirstOrDefault(t => t.Id == expertiseId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }



        [HttpPost]
        public async Task<IActionResult> SablonDuzenle(int updateId, EkspertizSablon sablonModel)
        {
            if (ModelState.IsValid)
            {
                if (sablonModel != null)
                {
                    // Geçerli kullanıcının CompanyId'sini al
                    var companyId = await GetCurrentUserCompanyId();

                    // Veritabanında updateId ve CompanyId ile eşleşen bir kayıt var mı kontrol et
                    var mevcutKayit = _db.EkspertizSablonTable.FirstOrDefault(e => e.Id == updateId && e.CompanyId == companyId);
                    if (mevcutKayit != null)
                    {
                        // Eşleşen kayıt varsa, reflection kullanarak tüm alanları güncelle
                        foreach (var property in typeof(EkspertizSablon).GetProperties())
                        {
                            if (property.Name != "Id" && property.Name != "CompanyId") // Id ve CompanyId alanlarını atla
                            {
                                var newValue = property.GetValue(sablonModel);
                                if (newValue != null)
                                {
                                    property.SetValue(mevcutKayit, newValue);
                                }
                            }
                        }

                        // Değişiklikleri kaydet
                        _db.SaveChanges();
                    }

                    return RedirectToAction("Main"); // Redirect to the Main action
                }
            }

            return View();
        }







        [HttpPost]
        public IActionResult SablonSil(int id)
        {
            var sablon = _db.EkspertizSablonTable.FirstOrDefault(s => s.Id == id);
            if (sablon != null)
            {
                _db.EkspertizSablonTable.Remove(sablon);
                _db.SaveChanges();
                return RedirectToAction("Try");
            }
            return Json(new { success = false, message = "Şablon bulunamadı." });
        }






        [HttpPost]
        public async Task<IActionResult> CombinedModel(Deneme1 deneme1model, Deneme2 deneme2model, CarModel carModel, VehicleModels vehicleModel)
        {
            if (ModelState.IsValid)
            {
                // Şu anda giriş yapmış kullanıcının Id'sini al
                var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
                var user = await _userManager.FindByIdAsync(userId);

                if (user != null)
                {
                    // Kullanıcının CompanyId'sini al ve Deneme1 modeline ata
                    deneme1model.CompanyId = user.CompanyId;
                }
                // Deneme1s tablosunda telefon numarasıyla eşleşen mevcut bir müşteri olup olmadığını kontrol et
                var existingCustomer = _db.Deneme1s.FirstOrDefault(d => d.Telefon == deneme1model.Telefon);
                var aracMarka = _db.VehicleModelss.FirstOrDefault(vm => vm.Id == vehicleModel.AracMarkaId);
                if (existingCustomer != null)
               {
                    carModel.Tarih = DateTime.Now; // veya başka bir tarih bilgisi
                    // Eğer mevcut bir müşteri varsa, onun Id'sini kullan
                    carModel.MusteriId = existingCustomer.Id;
                    var aracMarkaName1 = aracMarka.Name;

                    // Deneme1Data'ya AracMarka bilgisini ekleyelim
                    carModel.AracMarka = aracMarkaName1;
                }
                else
                {
                    if (deneme1model != null)
                    {
                        // Deneme1Data için AracMarka bilgisini ekleyelim
                        if (vehicleModel.AracMarkaId != null)
                        {
                            // AracMarkaId'si modelin AracMarkaId'sine eşit olan VehicleModels örneğini bul

                            if (aracMarka != null)
                            {
                                // Bulunan aracMarka'nın Name özelliğine eriş
                                var aracMarkaName = aracMarka.Name;

                                // Deneme1Data'ya AracMarka bilgisini ekleyelim
                                carModel.AracMarka = aracMarkaName;
                            }
                        }

                        // Deneme1Data'yı ekle
                        _db.Deneme1s.Add(deneme1model);

                        // Değişiklikleri kaydet
                        _db.SaveChanges();

                        // Deneme1model'in Id'sini al
                        carModel.MusteriId = deneme1model.Id;
                    }
                }

                // Mevcut şasi numarasıyla eşleşen bir CarModel var mı kontrol et
                var existingCarModel = _db.CarModelTable.FirstOrDefault(cm => cm.SaseNo == carModel.SaseNo);

                if (existingCarModel != null)
                {
                    // Eğer aynı şasi numarasıyla eşleşen bir CarModel varsa, Deneme2'yi güncelle
                    var existingDeneme2 = _db.Deneme2s.FirstOrDefault(d2 => d2.MusteriId == existingCarModel.MusteriId && d2.Id == existingCarModel.EkspertizId);

                    if (existingDeneme2 != null)
                    {
                        carModel.Tarih = DateTime.Now; // veya başka bir tarih bilgisi
                        // Deneme2 verilerini güncelle
                        existingDeneme2.DipNot = deneme2model.DipNot; 
                        existingDeneme2.ABS = deneme2model.ABS;
                        existingDeneme2.ABSFren = deneme2model.ABSFren;
                        existingDeneme2.Airbag = deneme2model.Airbag;
                        existingDeneme2.AksKontrol = deneme2model.AksKontrol;
                        existingDeneme2.AkuDurum = deneme2model.AkuDurum;
                        existingDeneme2.Amortisor = deneme2model.Amortisor;
                        existingDeneme2.AracAltıMuhafaza = deneme2model.AracAltıMuhafaza;
                        existingDeneme2.ArkaTampon = deneme2model.ArkaTampon;
                        existingDeneme2.Aynalar = deneme2model.Aynalar;
                        existingDeneme2.Bagaj = deneme2model.Bagaj;
                        existingDeneme2.Camlar = deneme2model.Camlar;
                        existingDeneme2.ContaYanik = deneme2model.ContaYanik;
                        existingDeneme2.Davlumbaz = deneme2model.Davlumbaz;
                        existingDeneme2.Difransiyel = deneme2model.Difransiyel;
                        existingDeneme2.DingilKontrol = deneme2model.DingilKontrol;
                        existingDeneme2.DireksiyonPompa = deneme2model.DireksiyonPompa;
                        existingDeneme2.Dosemeler = deneme2model.Dosemeler;
                        existingDeneme2.ESP = deneme2model.ESP;
                        existingDeneme2.ESR = deneme2model.ESR;
                        existingDeneme2.EgsozSitem = deneme2model.EgsozSitem;
                        existingDeneme2.ElektirikliDireksiyon = deneme2model.ElektirikliDireksiyon;
                        existingDeneme2.EnjektorDurum = deneme2model.EnjektorDurum;
                        existingDeneme2.Farlar = deneme2model.Farlar;
                        existingDeneme2.FrenBalatalari = deneme2model.FrenBalatalari;
                        existingDeneme2.FrenDiskleri = deneme2model.FrenDiskleri;
                        existingDeneme2.FrenHidrolik = deneme2model.FrenHidrolik;
                        existingDeneme2.Gosterge = deneme2model.Gosterge;
                        existingDeneme2.HasarKmNot = deneme2model.HasarKmNot;
                        existingDeneme2.HavaFiltreKabinDurum = deneme2model.HavaFiltreKabinDurum;
                        existingDeneme2.HavuzSaci = deneme2model.HavuzSaci;
                        existingDeneme2.Helezonlar = deneme2model.Helezonlar;
                        existingDeneme2.HizSabitleyici = deneme2model.HizSabitleyici;
                        existingDeneme2.Jantlar = deneme2model.Jantlar;
                        existingDeneme2.Kaput = deneme2model.Kaput;
                        existingDeneme2.Klima = deneme2model.Klima;
                        existingDeneme2.KlimaElektroniği = deneme2model.KlimaElektroniği;
                        existingDeneme2.Korna = deneme2model.Korna;
                        existingDeneme2.LastikBasınçElektroniği = deneme2model.LastikBasınçElektroniği;
                        existingDeneme2.Lastikler = deneme2model.Lastikler;
                        existingDeneme2.MotorArızaLambası = deneme2model.MotorArızaLambası;
                        existingDeneme2.MotorBeyinElektroniği = deneme2model.MotorBeyinElektroniği;
                        existingDeneme2.MotorFabrika = deneme2model.MotorFabrika;
                        existingDeneme2.MotorGenel = deneme2model.MotorGenel;
                        existingDeneme2.MotorNot = deneme2model.MotorNot;
                        existingDeneme2.MotorOlculen = deneme2model.MotorOlculen;
                        existingDeneme2.MotorYag = deneme2model.MotorYag;
                        existingDeneme2.OnTampon = deneme2model.OnTampon;
                        existingDeneme2.ParkSensorleri = deneme2model.ParkSensorleri;
                        existingDeneme2.Radyo = deneme2model.Radyo;
                        existingDeneme2.RotKollari = deneme2model.RotKollari;
                        existingDeneme2.SagArkaCamurluk = deneme2model.SagArkaCamurluk;
                        existingDeneme2.SagArkaKapi = deneme2model.SagArkaKapi;
                        existingDeneme2.SagArkaSase = deneme2model.SagArkaSase;
                        existingDeneme2.SagMaspiyelArka = deneme2model.SagMaspiyelArka;
                        existingDeneme2.SagMaspiyelOn = deneme2model.SagMaspiyelOn;
                        existingDeneme2.SagOnCamurluk = deneme2model.SagOnCamurluk;
                        existingDeneme2.SagOnDirek = deneme2model.SagOnDirek;
                        existingDeneme2.SagOnKapi = deneme2model.SagOnKapi;
                        existingDeneme2.SagOnSase = deneme2model.SagOnSase;
                        existingDeneme2.SagOrtaDirek = deneme2model.SagOrtaDirek;
                        existingDeneme2.SalincakBurc = deneme2model.SalincakBurc;
                        existingDeneme2.SanzumanDebriyaj = deneme2model.SanzumanDebriyaj;
                        existingDeneme2.SağArkaDirek = deneme2model.SağArkaDirek;
                        existingDeneme2.Silecekler = deneme2model.Silecekler;
                        existingDeneme2.SolArkaCamurluk = deneme2model.SolArkaCamurluk;
                        existingDeneme2.SolArkaDirek = deneme2model.SolArkaDirek;
                        existingDeneme2.SolArkaKapi = deneme2model.SolArkaKapi;
                        existingDeneme2.SolArkaSase = deneme2model.SolArkaSase;
                        existingDeneme2.SolMaspiyelArka = deneme2model.SolMaspiyelArka;

                        existingDeneme2.SolMaspiyelOn = deneme2model.SolMaspiyelOn;
                        existingDeneme2.SolOnCamurluk = deneme2model.SolOnCamurluk;
                        existingDeneme2.SolOnDirek = deneme2model.SolOnDirek;
                        existingDeneme2.SolOnKapi = deneme2model.SolOnKapi;
                        existingDeneme2.SolOnSase = deneme2model.SolOnSase;
                        existingDeneme2.SolOrtaDirek = deneme2model.SolOrtaDirek;
                        existingDeneme2.Stepne = deneme2model.Stepne;
                        existingDeneme2.Sunroof = deneme2model.Sunroof;
                        existingDeneme2.Tavan = deneme2model.Tavan;
                        existingDeneme2.TurboDurum = deneme2model.TurboDurum;
                        existingDeneme2.TurboIntercoller = deneme2model.TurboIntercoller;
                        existingDeneme2.VKayis = deneme2model.VKayis;
                        existingDeneme2.YagSizdirmazlik = deneme2model.YagSizdirmazlik;
                        existingDeneme2.YakitSistem = deneme2model.YakitSistem;
                        existingDeneme2.YakitSizdirmazlik = deneme2model.YakitSizdirmazlik;
                        existingDeneme2.YakıtHortumlari = deneme2model.YakıtHortumlari;
                        existingDeneme2.not_AksKontrol = deneme2model.not_AksKontrol;
                        existingDeneme2.not_Amartisor = deneme2model.not_Amartisor;
                        existingDeneme2.not_AracAltıMuhafaza = deneme2model.not_AracAltıMuhafaza;
                        existingDeneme2.not_Aynalar = deneme2model.not_Aynalar;
                        existingDeneme2.not_Camlar = deneme2model.not_Camlar;
                        existingDeneme2.not_Davlumbaz = deneme2model.not_Davlumbaz;
                        existingDeneme2.not_Difransiyel = deneme2model.not_Difransiyel;
                        existingDeneme2.not_DingilKontrol = deneme2model.not_DingilKontrol;
                        existingDeneme2.not_Farlar = deneme2model.not_Farlar;
                        existingDeneme2.not_FrenBalatalari = deneme2model.not_FrenBalatalari;
                        existingDeneme2.not_FrenDiskleri = deneme2model.not_FrenDiskleri;
                        existingDeneme2.not_Helezonlar = deneme2model.not_Helezonlar;
                        existingDeneme2.not_Jantlar = deneme2model.not_Jantlar;
                        existingDeneme2.not_Klima = deneme2model.not_Klima;
                        existingDeneme2.not_Lastikler = deneme2model.not_Lastikler;
                        existingDeneme2.not_RotKollari = deneme2model.not_RotKollari;
                        existingDeneme2.not_SalincakBurc = deneme2model.not_SalincakBurc;
                        existingDeneme2.not_Silecekler = deneme2model.not_Silecekler;
                        existingDeneme2.not_Stepne = deneme2model.not_Stepne;
                        existingDeneme2.not_Sunroof = deneme2model.not_Sunroof;
                        existingDeneme2.not_YakıtHortumlari = deneme2model.not_YakıtHortumlari;
                        existingDeneme2.not_abs = deneme2model.not_abs;
                        existingDeneme2.not_abs_fren = deneme2model.not_abs_fren;
                        existingDeneme2.not_airbag = deneme2model.not_airbag;
                        existingDeneme2.not_dosemeler = deneme2model.not_dosemeler;
                        existingDeneme2.not_elektrikli_direksiyon = deneme2model.not_elektrikli_direksiyon;
                        existingDeneme2.not_esp = deneme2model.not_esp;
                        existingDeneme2.not_esr = deneme2model.not_esr;
                        existingDeneme2.not_gosterge_panelleri = deneme2model.not_gosterge_panelleri;
                        existingDeneme2.not_hiz_sabitleyici = deneme2model.not_hiz_sabitleyici;
                        existingDeneme2.not_klima_elektronigi = deneme2model.not_klima_elektronigi;
                        existingDeneme2.not_korna = deneme2model.not_korna;
                        existingDeneme2.not_lastik_basinc = deneme2model.not_lastik_basinc;
                        existingDeneme2.not_motor_ariza_lambasi = deneme2model.not_motor_ariza_lambasi;
                        existingDeneme2.not_motor_beyin_elektroniği = deneme2model.not_motor_beyin_elektroniği;
                        existingDeneme2.not_park_sensorleri = deneme2model.not_park_sensorleri;
                        existingDeneme2.not_radyo_teyp = deneme2model.not_radyo_teyp;
                        existingDeneme2.not_sanziman_elektroniği = deneme2model.not_sanziman_elektroniği;
                        existingDeneme2.ntsi_AkuDurum = deneme2model.ntsi_AkuDurum;
                        existingDeneme2.ntsi_ArkaTampon = deneme2model.ntsi_ArkaTampon;
                        existingDeneme2.ntsi_Bagaj = deneme2model.ntsi_Bagaj;
                        existingDeneme2.ntsi_ContaYanik = deneme2model.ntsi_ContaYanik;
                        existingDeneme2.ntsi_DireksiyonPompa = deneme2model.ntsi_DireksiyonPompa;
                        existingDeneme2.ntsi_EgsozSitem = deneme2model.ntsi_EgsozSitem;
                        existingDeneme2.ntsi_EnjektorDurum = deneme2model.ntsi_EnjektorDurum;
                        existingDeneme2.ntsi_FrenHidrolik = deneme2model.ntsi_FrenHidrolik;
                        existingDeneme2.ntsi_HavaFiltreKabinDurum = deneme2model.ntsi_HavaFiltreKabinDurum;
                        existingDeneme2.ntsi_HavuzSaci = deneme2model.ntsi_HavuzSaci;
                        existingDeneme2.ntsi_Kaput = deneme2model.ntsi_Kaput;
                        existingDeneme2.ntsi_MotorGenel = deneme2model.ntsi_MotorGenel;
                        existingDeneme2.ntsi_MotorYag = deneme2model.ntsi_MotorYag;
                        existingDeneme2.ntsi_OnTampon = deneme2model.ntsi_OnTampon;
                        existingDeneme2.ntsi_SagArkaCamurluk = deneme2model.ntsi_SagArkaCamurluk;
                        existingDeneme2.ntsi_SagArkaKapi = deneme2model.ntsi_SagArkaKapi;
                        existingDeneme2.ntsi_SagArkaSase = deneme2model.ntsi_SagArkaSase;
                        existingDeneme2.ntsi_SagMaspiyelArka = deneme2model.ntsi_SagMaspiyelArka;
                        existingDeneme2.ntsi_SagMaspiyelOn = deneme2model.ntsi_SagMaspiyelOn;
                        existingDeneme2.ntsi_SagOnCamurluk = deneme2model.ntsi_SagOnCamurluk;
                        existingDeneme2.ntsi_SagOnDirek = deneme2model.ntsi_SagOnDirek;
                        existingDeneme2.ntsi_SagOnKapi = deneme2model.ntsi_SagOnKapi;
                        existingDeneme2.ntsi_SagOnSase = deneme2model.ntsi_SagOnSase;
                        existingDeneme2.ntsi_SagOrtaDirek = deneme2model.ntsi_SagOrtaDirek;
                        existingDeneme2.ntsi_SanzumanDebriyaj = deneme2model.ntsi_SanzumanDebriyaj;
                        existingDeneme2.ntsi_SağArkaDirek = deneme2model.ntsi_SağArkaDirek;
                        existingDeneme2.ntsi_SolArkaCamurluk = deneme2model.ntsi_SolArkaCamurluk;
                        existingDeneme2.ntsi_SolArkaDirek = deneme2model.ntsi_SolArkaDirek;
                        existingDeneme2.ntsi_SolArkaKapi = deneme2model.ntsi_SolArkaKapi;
                        existingDeneme2.ntsi_SolArkaSase = deneme2model.ntsi_SolArkaSase;
                        existingDeneme2.ntsi_SolMaspiyelArka = deneme2model.ntsi_SolMaspiyelArka;
                        existingDeneme2.ntsi_SolMaspiyelOn = deneme2model.ntsi_SolMaspiyelOn;
                        existingDeneme2.ntsi_SolOnCamurluk = deneme2model.ntsi_SolOnCamurluk;
                        existingDeneme2.ntsi_SolOnDirek = deneme2model.ntsi_SolOnDirek;
                        existingDeneme2.ntsi_SolOnKapi = deneme2model.ntsi_SolOnKapi;
                        existingDeneme2.ntsi_SolOnSase = deneme2model.ntsi_SolOnSase;
                        existingDeneme2.ntsi_SolOrtaDirek = deneme2model.ntsi_SolOrtaDirek;
                        existingDeneme2.ntsi_Tavan = deneme2model.ntsi_Tavan;
                        existingDeneme2.ntsi_TurboDurum = deneme2model.ntsi_TurboDurum;
                        existingDeneme2.ntsi_TurboIntercoller = deneme2model.ntsi_TurboIntercoller;
                        existingDeneme2.ntsi_VKayis = deneme2model.ntsi_VKayis;
                        existingDeneme2.ntsi_YagSizdirmazlik = deneme2model.ntsi_YagSizdirmazlik;
                        existingDeneme2.ntsi_YakitSistem = deneme2model.ntsi_YakitSistem;
                        existingDeneme2.ŞanzımanElektroniği = deneme2model.ŞanzımanElektroniği;

                        existingDeneme2.ArkaPanel = deneme2model.ArkaPanel;
                        existingDeneme2.ArkaPodye = deneme2model.ArkaPodye;
                        existingDeneme2.OnPanel = deneme2model.OnPanel;
                        existingDeneme2.OnPodye = deneme2model.OnPodye;
                        existingDeneme2.ntsi_ArkaPanel = deneme2model.ntsi_ArkaPanel;
                        existingDeneme2.ntsi_ArkaPodye = deneme2model.ntsi_ArkaPodye;
                        existingDeneme2.ntsi_OnPanel = deneme2model.ntsi_OnPanel;
                        existingDeneme2.ntsi_OnPodye = deneme2model.ntsi_OnPodye;

                        // Diğer güncelleme işlemleri burada yapılacak

                        _db.SaveChanges();
                    }
                }
                else
                {
                    if (deneme2model != null)
                    {
                        // Deneme2Data'nın MusteriId'sini carModel.MusteriId ile eşitle
                        deneme2model.CompanyId = user.CompanyId;
                        // Deneme2Data'nın MusteriId'sini carModel.MusteriId ile eşitle
                        deneme2model.MusteriId = carModel.MusteriId;
                        // Deneme2Data'yı ekle
                        _db.Deneme2s.Add(deneme2model);
                        _db.SaveChanges();

                        // Deneme2model'in Id'sini al
                        int deneme2modelId = deneme2model.Id;

                        if (carModel != null)
                        {
                            // CarModel'in EkspertizId'sini deneme2modelId ile eşitle
                            carModel.EkspertizId = deneme2modelId;

                            // Kullanıcının CompanyId'sini CarModel modeline ata
                            carModel.CompanyId = user.CompanyId;

                            carModel.Tarih = DateTime.Now; // veya başka bir tarih bilgisi
                                                           // CarModelData'yı ekle
                            _db.CarModelTable.Add(carModel);
                            _db.SaveChanges();
                        }
                    }
                }

                // Yönlendirme işlemi
                return RedirectToAction("Deneme");
            }

            return View();
        }



        public IActionResult SearchCar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Arat(string search)
        {
            // Kullanıcının CompanyId değerini al
            int companyId = await GetCurrentUserCompanyId();

            if (string.IsNullOrWhiteSpace(search))
            {
                // Eğer search parametresi boş veya null ise, tüm araçları CompanyId ile getir
                var allCars = _db.CarModelTable.Where(c => c.CompanyId == companyId).ToList();
                return View("SearchCar", allCars);
            }

            // Deneme1 modelinde müşteri adı ile eşleşen veriyi bul
            var musteri = _db.Deneme1s.FirstOrDefault(m => m.MusteriAd == search);

            if (musteri != null)
            {
                // Eşleşen müşteri ID'si
                int musteriId = musteri.Id;

                // CarModel modelinde müşteri ID'si ve CompanyId ile eşleşen verileri bul
                var carList = _db.CarModelTable.Where(c => c.MusteriId == musteriId && c.CompanyId == companyId).ToList();

                // Verileri SearchCar action'ına gönder
                return View("SearchCar", carList);
            }

            // CarModel modelinde şase numarası ve CompanyId ile eşleşen veriyi bul
            var carBySaseNo = _db.CarModelTable.Where(c => c.SaseNo == search && c.CompanyId == companyId).ToList();

            if (carBySaseNo.Any())
            {
                // Şase numarası ile eşleşen araç verilerini gönder
                return View("SearchCar", carBySaseNo);
            }

            // CarModel modelinde plaka numarası ve CompanyId ile eşleşen veriyi bul
            var carByPlate = _db.CarModelTable.Where(p => p.AracPlaka == search && p.CompanyId == companyId).ToList();

            if (carByPlate.Any())
            {
                return View("SearchCar", carByPlate);
            }

            // CarModel modelinde marka ve CompanyId ile eşleşen veriyi bul
            var carByBrand = _db.CarModelTable.Where(p => p.AracMarka == search && p.CompanyId == companyId).ToList();

            if (carByBrand.Any())
            {
                return View("SearchCar", carByBrand);
            }

            // CarModel modelinde model ve CompanyId ile eşleşen veriyi bul
            var carByModel = _db.CarModelTable.Where(p => p.AracModel == search && p.CompanyId == companyId).ToList();

            if (carByModel.Any())
            {
                return View("SearchCar", carByModel);
            }

            // Deneme1 modelinde telefon numarası ile eşleşen veriyi bul
            var carByPhone = _db.Deneme1s.FirstOrDefault(m => m.Telefon == search);

            if (carByPhone != null)
            {
                int getId = carByPhone.Id;
                var carList1 = _db.CarModelTable.Where(c => c.MusteriId == getId && c.CompanyId == companyId).ToList();
                return View("SearchCar", carList1);
            }

            // Eşleşme yoksa, boş bir liste gönder
            return View("SearchCar", new List<CarModel>());
        }



        public IActionResult CustomerInfo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditCar(int editCarId)
        {
            var musteri = _db.CarModelTable.FirstOrDefault(m => m.Id == editCarId);
            if (musteri != null)
            {
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(musteri);
                }
                return View("EditC", musteri);
            }
            return View("Error");
        }


        [HttpPost]
        public IActionResult UpdateCustomer(Deneme1 model, int id)
        {
            // Veritabanında mevcut müşteri kaydını telefon numarasına göre bul
            var musteri = _db.Deneme1s.FirstOrDefault(m => m.Id == id);
            if (musteri != null)
            {
                // Gelen model ile mevcut müşteri kaydını güncelle
                musteri.MusteriAd = model.MusteriAd;
                musteri.Telefon = model.Telefon;
                musteri.Email = model.Email;

                // Değişiklikleri kaydet
                _db.SaveChanges();

                return RedirectToAction("Main");
            }
            else
            {
                // Müşteri bulunamazsa bir hata mesajı veya başka bir işlem yapabilirsiniz
                TempData["ErrorMessage"] = "Müşteri bulunamadı.";
            }

            // Güncelleme işleminden sonra bir başka sayfaya yönlendirme yapabilirsiniz
            return RedirectToAction("Main");
        }

        [HttpGet]
        public IActionResult EditC()
        {
            return View();
        }





        [HttpPost]
        public IActionResult UpdateCar(int id, CarModel model)
        {
            var musteri = _db.CarModelTable.FirstOrDefault(m => m.Id == id);
            if (musteri != null)
            {
                // Aracın diğer bilgilerini güncelle
                musteri.AracPlaka = model.AracPlaka;
                musteri.SaseNo = model.SaseNo;
                musteri.AracModel = model.AracModel;
                musteri.YakitTipi = model.YakitTipi;
                musteri.Yil = model.Yil;
                musteri.AracKm = model.AracKm;
                musteri.YedekAnahtar = model.YedekAnahtar;
                musteri.Ucret = model.Ucret;
                musteri.OdemeSekli = model.OdemeSekli;
                musteri.AracMarkaId = model.AracMarkaId;

                // Aracın markasını bul
                var aracMarka = _db.VehicleModelss.FirstOrDefault(vm => vm.Id == model.AracMarkaId);
                if (aracMarka != null)
                {
                    // Aracın marka bilgisini güncelle
                    musteri.AracMarka = aracMarka.Name;
                }
                musteri.Tarih = DateTime.Now; // veya başka bir tarih bilgisi


                // Değişiklikleri kaydet
                _db.SaveChanges();

                return RedirectToAction("Main"); // Değiştirilmesi gereken bir action adı belirtin
            }
            return View("Error");
        }


        

        [HttpGet]
        public IActionResult GetTemplate(int templateId)
        {
            var template = _db.EkspertizSablonTable
                            .FirstOrDefault(t => t.Id == templateId);

            if (template == null)
            {
                return NotFound();
            }

            return Json(template);
        }

        [HttpGet]
        public IActionResult CarId(int carId)
        {
            var update = _db.CarModelTable
                            .FirstOrDefault(t => t.MusteriId == carId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpGet]
        public IActionResult GetCustomer(int expertiseId)
        {
            var update = _db.Deneme1s
                            .FirstOrDefault(t => t.Id == expertiseId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpPost]
        public IActionResult EditCustomer(Deneme1 model, int customerId)
        {
            var update = _db.Deneme1s.FirstOrDefault(t => t.Id == customerId);
            if (update != null)
            {
                // Gelen verilerle güncelle
                update.MusteriAd = model.MusteriAd;
                update.Telefon = model.Telefon;
                update.Email = model.Email;

                // Veritabanında değişiklikleri kaydet
                _db.SaveChanges();
            }

            return RedirectToAction("Main"); // Yönlendirilecek sayfa
        }
        [HttpGet]
        public IActionResult GetCustomer1(int customerId)
        {
            var update = _db.Deneme1s
                            .FirstOrDefault(t => t.Id == customerId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }
        [HttpGet]
        public IActionResult EditCustomer(int customerId)
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCustomerCar(int searchCarId)
        {
            var update = _db.Deneme1s
                            .FirstOrDefault(t => t.Id == searchCarId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpGet]
        public IActionResult GetCustomerCar1(int searchCarId, int carId)
        {
            var update = _db.CarModelTable
                            .FirstOrDefault(t => t.MusteriId == searchCarId && t.Id == carId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpGet]
        public IActionResult GetSearchCarDetails(int ekspertizId)
        {
            var carDetails = _db.Deneme2s
                                .FirstOrDefault(t => t.Id == ekspertizId);

            if (carDetails == null)
            {
                return NotFound();
            }
            
            return Json(carDetails);
        }




        [HttpGet]
        public IActionResult GetDuzenleId(int duzenleId)
        {
            var update = _db.CarModelTable
                            .FirstOrDefault(t => t.MusteriId == duzenleId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpPost]
        public IActionResult DeleteCar(int id, int carId, int exId)
        {
            var carToDelete = _db.CarModelTable.FirstOrDefault(c => c.MusteriId == id && c.Id == carId);
            if (carToDelete != null)
            {
                // İlgili müşteriyi sil
                _db.CarModelTable.Remove(carToDelete);
                _db.SaveChanges(); // Değişiklikleri kaydet

                // Deneme2 tablosundan ilgili öğeyi bul
                var associatedItem = _db.Deneme2s.FirstOrDefault(d => d.MusteriId == id && d.Id == exId);

                if (associatedItem != null)
                {
                    // İlgili öğeyi sil
                    _db.Deneme2s.Remove(associatedItem);
                    _db.SaveChanges(); // Değişiklikleri kaydet
                }

                

                return RedirectToAction("Main"); // İşlem başarılıysa başka bir sayfaya yönlendir
            }
            else
            {
                return NotFound(); // Müşteri bulunamadıysa 404 Not Found hatası döndür
            }
        }
    }
}
