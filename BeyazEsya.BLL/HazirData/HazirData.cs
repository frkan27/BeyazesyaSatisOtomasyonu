using BeyazEsya.BLL.Repository;
using BeyazEsya.DAL;
using BeyazEsya.Model.Entities;
using System;
using System.Linq;

namespace BeyazEsya.BLL.HazirData
{
    public class HazirData
    {
        public void VeriÜret()
        {
            if (new KategoriRepo().GetAll().Any() || new UrunRepo().GetAll().Any()) return;
            KategoriUret();
            UrunUret();
            MusteriUret();
            SatisUret();
        }

        private void UrunUret()
        {
            Urun urun = null;
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    switch (i)
                    {
                        case 0:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Bosch Buzdolabı",
                                Fiyat = 7000

                            };
                            break;
                        case 1:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Arçelik Buzdolabı",
                                Fiyat = 6000

                            };
                            break;
                        case 2:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "LG Buzdolabı",
                                Fiyat = 4000
                            };
                            break;
                        case 3:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Samsung Buzdolabı",
                                Fiyat = 7500
                            };
                            break;
                        case 4:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "Bosch Çamaşır Makinesi",
                                Fiyat = 4000
                            };
                            break;
                        case 5:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "Arçelik Çamaşır Makinesi",
                                Fiyat = 3000
                            };
                            break;
                        case 6:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "LG Çamaşır Makinesi",
                                Fiyat = 3200
                            };
                            break;
                        case 7:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "Samsung Çamaşır Makinesi",
                                Fiyat = 3700
                            };
                            break;
                        case 8:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "Bosch Bulaşık Makinesi",
                                Fiyat = 3700
                            };
                            break;
                        case 9:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "Arçelik Bulaşık Makinesi",
                                Fiyat = 3200
                            };
                            break;
                        case 10:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "Samsung Bulaşık Makinesi",
                                Fiyat = 4700
                            };
                            break;
                        case 11:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "LG Bulaşık Makinesi",
                                Fiyat = 4200
                            };
                            break;
                        case 12:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "Bosch Fırın",
                                Fiyat = 2500
                            };
                            break;
                        case 13:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "Arçelik Fırın",
                                Fiyat = 2200
                            };
                            break;
                        case 14:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "Samsung Fırın",
                                Fiyat = 2000
                            };
                            break;
                        case 15:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "LG Fırın",
                                Fiyat = 2700
                            };
                            break;
                        case 16:
                            urun = new Urun()
                            {
                                KategoriId = 5,
                                UrunAdi = "Bosch Derin Dondurucu",
                                Fiyat = 2700
                            };
                            break;
                        case 17:
                            urun = new Urun()
                            {
                                KategoriId = 5,
                                UrunAdi = "Arçelik Derin Dondurucu",
                                Fiyat = 2900
                            };
                            break;
                        case 18:
                            urun = new Urun()
                            {
                                KategoriId = 5,
                                UrunAdi = "Samsung Derin Dondurucu",
                                Fiyat = 2500
                            };
                            break;
                        case 19:
                            urun = new Urun()
                            {
                                KategoriId = 5,
                                UrunAdi = "LG Derin Dondurucu",
                                Fiyat = 2400
                            };
                            break;

                        default:
                            break;
                    }
                    new UrunRepo().Insert(urun);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void KategoriUret()
        {
            Kategori kategori = null;
            try
            {

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Buzdolabı"

                            };
                            break;
                        case 1:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "ÇamaşırMakinesi"

                            };
                            break;
                        case 2:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "BulaşıkMakinesi"

                            };
                            break;
                        case 3:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Fırın"

                            };
                            break;
                        case 4:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "DerinDondurucu"

                            };
                            break;


                        default:
                            break;
                    }
                    new KategoriRepo().Insert(kategori);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void MusteriUret()
        {
            MyContext db = new MyContext();
            Musteri musteri = null;

            try
            {

                for (int i = 0; i < 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            musteri = new Musteri()
                            {
                                MusteriAdi = "Yusuf Yazıcı",
                                Adres = "Trabzon",
                              

                            };
                            break;
                        case 1:
                            musteri = new Musteri()
                            {
                                MusteriAdi = "Merih Demiral",
                                Adres = "Torino",
                                

                            };
                            break;
                        case 2:
                            musteri = new Musteri()
                            {
                                MusteriAdi = "Mert Günok",
                                Adres = "İstanbul",
                              

                            };
                            break;
                        case 3:
                            musteri = new Musteri()
                            {
                                MusteriAdi = "Cenk Tosun",
                                Adres = "İngiltere",
                               

                            };
                            break;
                        case 4:
                            musteri = new Musteri()
                            {
                                MusteriAdi = "Okay Yokuşlu",
                                Adres = "İspanya",
                               

                            };
                            break;


                        default:
                            break;
                    }
                    new MusteriRepo().Insert(musteri);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void SatisUret()
        {

          
            Satis satis = null;
            Random sayiUret = new Random();
            try
            {
                for (int i = 1; i < 6; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                satis = new Satis
                                {
                                    MusteriId = i,
                                    UrunId = sayiUret.Next(1,4),
                                    Taksit = sayiUret.Next(1, 12),
                                    Pesinat = 500 + (100 * sayiUret.Next(1, 10)),
                                };
                                break;
                            case 1:
                                satis = new Satis
                                {
                                    MusteriId = i,
                                    UrunId = sayiUret.Next(5, 7),
                                    Taksit = sayiUret.Next(1, 12),
                                    Pesinat = 500 + (100 * sayiUret.Next(1, 10)),
                                };
                                break;
                            case 2:
                                satis = new Satis
                                {
                                    MusteriId = i,
                                    UrunId = sayiUret.Next(7, 11),
                                    Taksit = sayiUret.Next(1, 12),
                                    Pesinat = 500 + (100 * sayiUret.Next(1, 10)),
                                };
                                break;
                            case 3:
                                satis = new Satis
                                {
                                    MusteriId = i,
                                    UrunId = sayiUret.Next(11, 15),
                                    Taksit = sayiUret.Next(1, 12),
                                    Pesinat = 500 + (100 * sayiUret.Next(1, 10)),
                                };
                                break;
                            case 4:
                                satis = new Satis
                                {
                                    MusteriId = i,
                                    UrunId = sayiUret.Next(15, 20),
                                    Taksit = sayiUret.Next(1, 12),
                                    Pesinat = 500 + (100 * sayiUret.Next(1, 10)),
                                };
                                break;
                            default:
                                break;
                        }
                        new SatisDetayRepo().Insert(satis);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
