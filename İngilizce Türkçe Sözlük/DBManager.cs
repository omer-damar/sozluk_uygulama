using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje_Deneme_Yanılma
{
    public enum VeritabaniTipi
    {
        KullaniciBilgi,
        SozlukVocabulary
    }

    internal class DBManager
    {
        public static SqlConnection BaglantiGetir(VeritabaniTipi tip)
        {
            string connectionStringName;

            switch (tip)
            {
                case VeritabaniTipi.KullaniciBilgi:
                    connectionStringName = "KullaniciBilgi";
                    break;

                case VeritabaniTipi.SozlukVocabulary:
                    connectionStringName = "SozlukVocabulary";
                    break;

                default:
                    MessageBox.Show("Bilinmeyen veritabanı tipi.");
                    return null;
            }

            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[connectionStringName];

            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                MessageBox.Show(
                    "Veritabanı bağlantı ayarı bulunamadı: " + connectionStringName,
                    "Yapılandırma Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }

            try
            {
                SqlConnection baglanti = new SqlConnection(settings.ConnectionString);
                baglanti.Open();
                return baglanti;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Veritabanı bağlantı hatası:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Beklenmeyen bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
