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

        public async Task<IActionResult> Template()
        {
            int currentUserCompanyId = await GetCurrentUserCompanyId();
            var ekspertizSablonList = await _db.ExpertiseTemplateTable
                                              .Where(s => s.CompanyId == currentUserCompanyId && s.IsActive)
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
            var deneme1DataList = _db.CustomerTable.Where(d => d.CompanyId == companyId && d.IsActive).ToList();
            var ExpertiseModelDataList = _db.ExpertiseTable.Where(d => d.CompanyId == companyId).ToList();
            var carModelList = _db.CarModelTable.ToList();

            // CombinedList modelini doldurun
            var combinedList = new CombinedList
            {
                CustomerList = deneme1DataList,
                CarModelList = carModelList,
                ExpertiseList = ExpertiseModelDataList
            };

            // CompanyId'yi ViewBag'e ekleyin
            ViewBag.CurrentUserCompanyId = companyId;

            // CombinedList modelini ana sayfaya gönderin
            return View(combinedList);
        }



        [HttpGet("list")]
        public IActionResult DeleteCustomer()
        {
            var modelList = _db.CustomerTable.ToList();
            return Ok(modelList);
        }

        public IActionResult Report()
        {
            return View();
        }

        public IActionResult ExpertiseReport()
        {
            // Tüm EkspertizSablon kayıtlarını alıyoruz
            var ekspertizList = _db.ExpertiseTemplateTable.ToList();

            // View'a gönderiyoruz
            return View(ekspertizList);
        }




        [HttpPost]
        public IActionResult DeleteCustomer(int id)
        {
            var customerToDelete = _db.CustomerTable.FirstOrDefault(c => c.Id == id); // Veritabanından ilgili müşteriyi bul
            if (customerToDelete != null)
            {
                // İlgili müşteriyi sil
                customerToDelete.IsActive = false;
                _db.SaveChanges(); // Değişiklikleri kaydet


                var carTables = _db.CarModelTable.Where(c => c.MusteriId == id).ToList();

                if (carTables.Any())
                {
                    // Tüm eşleşen kayıtları sil
                    foreach (var car in carTables)
                    {
                        car.IsActive = false;
                    }
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
            var musteri = _db.CustomerTable.FirstOrDefault(d => d.Telefon == telefon && d.IsActive);
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
        public async Task<IActionResult> SablonEkle(ExpertiseTemplate sablonModel)
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

                    sablonModel.IsActive = true;
                    // EkspertizSablonData'yı ekle
                    _db.ExpertiseTemplateTable.Add(sablonModel);

                    // Değişiklikleri kaydet
                    await _db.SaveChangesAsync();

                    // Yönlendirme işlemi
                    return RedirectToAction("Template");
                }
            }

            return View();
        }



        [HttpGet]
        public IActionResult UpdateTemplate(int updateId)
        {
            var update = _db.ExpertiseTemplateTable
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
            var update = _db.ExpertiseTemplateTable
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
            var update = _db.ExpertiseTable
                            .FirstOrDefault(t => t.Id == expertiseId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }



        [HttpPost]
        public async Task<IActionResult> SablonDuzenle(int updateId, ExpertiseTemplate sablonModel)
        {
            if (ModelState.IsValid)
            {
                if (sablonModel != null)
                {
                    // Geçerli kullanıcının CompanyId'sini al
                    var companyId = await GetCurrentUserCompanyId();

                    // Veritabanında updateId ve CompanyId ile eşleşen bir kayıt var mı kontrol et
                    var mevcutKayit = _db.ExpertiseTemplateTable.FirstOrDefault(e => e.Id == updateId && e.CompanyId == companyId);
                    if (mevcutKayit != null)
                    {
                        // Eşleşen kayıt varsa, reflection kullanarak tüm alanları güncelle
                        foreach (var property in typeof(ExpertiseTemplate).GetProperties())
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

                        // IsActive özelliğini true olarak ayarla
                        mevcutKayit.IsActive = true;

                        // Değişiklikleri kaydet
                        await _db.SaveChangesAsync();
                    }

                    return RedirectToAction("Main"); // Redirect to the Main action
                }
            }

            return View(sablonModel); // Pass the model back to the view in case of an error
        }








        [HttpPost]
        public IActionResult SablonSil(int id)
        {
            var sablon = _db.ExpertiseTemplateTable.FirstOrDefault(s => s.Id == id);
            if (sablon != null)
            {
                sablon.IsActive = false;
                _db.SaveChanges();
                return RedirectToAction("Template");
            }
            return Json(new { success = false, message = "Şablon bulunamadı." });
        }






        [HttpPost]
        public async Task<IActionResult> CombinedModel(CustomerModel deneme1model, ExpertiseModel ExpertiseModelmodel, CarModel carModel, VehicleModels vehicleModel)
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

                // CustomerTable tablosunda telefon numarasıyla eşleşen mevcut bir müşteri olup olmadığını kontrol et
                var existingCustomer = _db.CustomerTable.FirstOrDefault(d => d.Telefon == deneme1model.Telefon && d.IsActive);
                var aracMarka = _db.VehicleModelss.FirstOrDefault(vm => vm.Id == vehicleModel.AracMarkaId);

                if (existingCustomer != null)
                {
                    carModel.Tarih = DateTime.Now; // veya başka bir tarih bilgisi
                                                   // Eğer mevcut bir müşteri varsa, onun Id'sini kullan
                    carModel.MusteriId = existingCustomer.Id;
                    carModel.AracMarka = aracMarka?.Name;
                }
                else
                {
                    if (deneme1model != null)
                    {
                        if (vehicleModel.AracMarkaId != null && aracMarka != null)
                        {
                            carModel.AracMarka = aracMarka.Name;
                        }
                        deneme1model.IsActive = true;
                        _db.CustomerTable.Add(deneme1model);
                        _db.SaveChanges();
                        carModel.MusteriId = deneme1model.Id;
                    }
                }

                // Mevcut şasi numarasıyla eşleşen bir CarModel var mı kontrol et
                var existingCarModel = _db.CarModelTable.FirstOrDefault(cm => cm.SaseNo == carModel.SaseNo && cm.IsActive);

                if (existingCarModel != null)
                {
                    // Mevcut carModel'ı güncelle
                    existingCarModel.AracPlaka = carModel.AracPlaka;
                    existingCarModel.AracMarka = carModel.AracMarka;
                    existingCarModel.AracMarkaId = carModel.AracMarkaId;
                    existingCarModel.AracModel = carModel.AracModel;
                    existingCarModel.YakitTipi = carModel.YakitTipi;
                    existingCarModel.Yil = carModel.Yil;
                    existingCarModel.AracKm = carModel.AracKm;
                    existingCarModel.YedekAnahtar = carModel.YedekAnahtar;
                    existingCarModel.Ucret = carModel.Ucret;
                    existingCarModel.OdemeSekli = carModel.OdemeSekli;
                    existingCarModel.Tarih = DateTime.Now; // veya başka bir tarih bilgisi

                    _db.CarModelTable.Update(existingCarModel);
                    _db.SaveChanges();

                    // Eğer aynı şasi numarasıyla eşleşen bir CarModel varsa bile, yeni bir ExpertiseModel ekle
                    if (ExpertiseModelmodel != null)
                    {
                        ExpertiseModelmodel.CompanyId = user.CompanyId;
                        ExpertiseModelmodel.MusteriId = carModel.MusteriId;
                        ExpertiseModelmodel.AracId = existingCarModel.Id;
                        ExpertiseModelmodel.AracPlaka = existingCarModel.AracPlaka;
                        ExpertiseModelmodel.SaseNo = existingCarModel.SaseNo;
                        ExpertiseModelmodel.AracMarka = existingCarModel.AracMarka;
                        ExpertiseModelmodel.AracMarkaId = existingCarModel.AracMarkaId;
                        ExpertiseModelmodel.AracModel = existingCarModel.AracModel;
                        ExpertiseModelmodel.YakitTipi = existingCarModel.YakitTipi;
                        ExpertiseModelmodel.Yil = existingCarModel.Yil;
                        ExpertiseModelmodel.AracKm = existingCarModel.AracKm;
                        ExpertiseModelmodel.YedekAnahtar = existingCarModel.YedekAnahtar;
                        ExpertiseModelmodel.Ucret = existingCarModel.Ucret;
                        ExpertiseModelmodel.OdemeSekli = existingCarModel.OdemeSekli;
                        ExpertiseModelmodel.Tarih = existingCarModel.Tarih;
                        ExpertiseModelmodel.IsActive = true;

                        _db.ExpertiseTable.Add(ExpertiseModelmodel);
                        _db.SaveChanges();

                        existingCarModel.EkspertizId = ExpertiseModelmodel.Id;
                        existingCarModel.CompanyId = user.CompanyId;

                        _db.CarModelTable.Update(existingCarModel);
                        _db.SaveChanges();
                    }
                }
                else
                {
                    if (ExpertiseModelmodel != null)
                    {
                        ExpertiseModelmodel.CompanyId = user.CompanyId;
                        ExpertiseModelmodel.MusteriId = carModel.MusteriId;

                        _db.CarModelTable.Add(carModel);
                        carModel.IsActive = true;
                        _db.SaveChanges();

                        ExpertiseModelmodel.AracId = carModel.Id;
                        ExpertiseModelmodel.AracPlaka = carModel.AracPlaka;
                        ExpertiseModelmodel.SaseNo = carModel.SaseNo;
                        ExpertiseModelmodel.AracMarka = carModel.AracMarka;
                        ExpertiseModelmodel.AracMarkaId = carModel.AracMarkaId;
                        ExpertiseModelmodel.AracModel = carModel.AracModel;
                        ExpertiseModelmodel.YakitTipi = carModel.YakitTipi;
                        ExpertiseModelmodel.Yil = carModel.Yil;
                        ExpertiseModelmodel.AracKm = carModel.AracKm;
                        ExpertiseModelmodel.YedekAnahtar = carModel.YedekAnahtar;
                        ExpertiseModelmodel.Ucret = carModel.Ucret;
                        ExpertiseModelmodel.OdemeSekli = carModel.OdemeSekli;
                        ExpertiseModelmodel.Tarih = DateTime.Now; // veya başka bir tarih bilgisi
                        ExpertiseModelmodel.IsActive = true;

                        _db.ExpertiseTable.Add(ExpertiseModelmodel);
                        _db.SaveChanges();

                        carModel.EkspertizId = ExpertiseModelmodel.Id;
                        carModel.CompanyId = user.CompanyId;
                        carModel.Tarih = DateTime.Now; // veya başka bir tarih bilgisi

                        _db.CarModelTable.Update(carModel);
                        _db.SaveChanges();
                    }
                }

                // Yönlendirme işlemi
                return RedirectToAction("ExpertiseReport");
            }

            return View();
        }




        public IActionResult SearchCar()
        {
            return View();
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
        public IActionResult UpdateCustomer(CustomerModel model, int id)
        {
            // Veritabanında mevcut müşteri kaydını telefon numarasına göre bul
            var musteri = _db.CustomerTable.FirstOrDefault(m => m.Id == id);
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
            var template = _db.ExpertiseTemplateTable
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
        public IActionResult GetCustomer(int musteriId)
        {
            var update = _db.CustomerTable
                            .FirstOrDefault(t => t.Id == musteriId);

            if (update == null)
            {
                return NotFound();
            }

            return Json(update);
        }

        [HttpPost]
        public IActionResult EditCustomer(CustomerModel model, int customerId)
        {
            var update = _db.CustomerTable.FirstOrDefault(t => t.Id == customerId);
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
            var update = _db.CustomerTable
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
            var update = _db.CustomerTable
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
        public IActionResult GetSearchCarDetails(int expertiseId)
        {
            var carDetails = _db.ExpertiseTable
                                .FirstOrDefault(t => t.Id == expertiseId);

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
                carToDelete.IsActive = false;
                _db.SaveChanges(); // Değişiklikleri kaydet





                return RedirectToAction("Main"); // İşlem başarılıysa başka bir sayfaya yönlendir
            }
            else
            {
                return NotFound(); // Müşteri bulunamadıysa 404 Not Found hatası döndür
            }
        }

        [HttpPost]
        public IActionResult ShowExpertises(string saseNo)
        {
            var saseRecords = _db.ExpertiseTable.Where(c => c.SaseNo == saseNo && c.IsActive).ToList();
            if (saseRecords.Any())
            {
                return PartialView("_ExpertiseDetails", saseRecords);
            }
            else
            {
                return Content("No records found.");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Arat(string search)
        {
            // Kullanıcının CompanyId değerini al
            int companyId = await GetCurrentUserCompanyId();

            // Deneme1 modelinde müşteri adı ile eşleşen veriyi bul
            var musteri = _db.CustomerTable.FirstOrDefault(m => m.MusteriAd == search && m.IsActive);

            if (musteri != null)
            {
                // Eşleşen müşteri ID'si
                int musteriId = musteri.Id;

                // CarModel modelinde müşteri ID'si ve CompanyId ile eşleşen verileri bul
                var carList = _db.CarModelTable.Where(c => c.MusteriId == musteriId && c.CompanyId == companyId && c.IsActive).ToList();

                // Verileri SearchCar action'ına gönder
                return View("SearchCar", carList);
            }

            // CarModel modelinde şase numarası ve CompanyId ile eşleşen veriyi bul
            var carBySaseNo = _db.CarModelTable.Where(c => c.SaseNo == search && c.CompanyId == companyId && c.IsActive).ToList();

            if (carBySaseNo.Any())
            {
                // Şase numarası ile eşleşen araç verilerini gönder
                return View("SearchCar", carBySaseNo);
            }

            // CarModel modelinde plaka numarası ve CompanyId ile eşleşen veriyi bul
            var carByPlate = _db.CarModelTable.Where(p => p.AracPlaka == search && p.CompanyId == companyId && p.IsActive).ToList();

            if (carByPlate.Any())
            {
                return View("SearchCar", carByPlate);
            }

            // CarModel modelinde marka ve CompanyId ile eşleşen veriyi bul
            var carByBrand = _db.CarModelTable.Where(p => p.AracMarka == search && p.CompanyId == companyId && p.IsActive).ToList();

            if (carByBrand.Any())
            {
                return View("SearchCar", carByBrand);
            }

            // CarModel modelinde model ve CompanyId ile eşleşen veriyi bul
            var carByModel = _db.CarModelTable.Where(p => p.AracModel == search && p.CompanyId == companyId && p.IsActive).ToList();

            if (carByModel.Any())
            {
                return View("SearchCar", carByModel);
            }

            // Deneme1 modelinde telefon numarası ile eşleşen veriyi bul
            var carByPhone = _db.CustomerTable.FirstOrDefault(m => m.Telefon == search && m.IsActive);

            if (carByPhone != null)
            {
                int getId = carByPhone.Id;
                var carList1 = _db.CarModelTable.Where(c => c.MusteriId == getId && c.CompanyId == companyId && c.IsActive).ToList();
                return View("SearchCar", carList1);
            }

            // Eşleşme yoksa, boş bir liste gönder
            return View("SearchCar", new List<CarModel>());
        }

        public IActionResult SearchExpertise()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchExpertise(string search)
        {
            int companyId = await GetCurrentUserCompanyId();
            var carByPlate = _db.ExpertiseTable.Where(p => p.AracPlaka == search && p.CompanyId == companyId).ToList();

            if (carByPlate.Any())
            {
                return View("SearchExpertise", carByPlate);
            }

            var carBySase = _db.ExpertiseTable.Where(p => p.SaseNo == search && p.CompanyId == companyId).ToList();

            if (carBySase.Any())
            {
                return View("SearchExpertise", carBySase);
            }

            var carByMarka = _db.ExpertiseTable.Where(p => p.AracMarka == search && p.CompanyId == companyId).ToList();

            if (carByMarka.Any())
            {
                return View("SearchExpertise", carByMarka);
            }

            var carByModel = _db.ExpertiseTable.Where(p => p.AracModel == search && p.CompanyId == companyId).ToList();

            if (carByModel.Any())
            {
                return View("SearchExpertise", carByModel);
            }

            return View();
        }


    }
}
