using BarcodeLib;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public class Security
    {
        //Encrypting
        public static string Encrypt(string plain_text)
        {
            byte[] encrypted = Encoding.Unicode.GetBytes(plain_text);
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string encrypted)
        {
            byte[] decrypted = Convert.FromBase64String(encrypted);
            return Encoding.Unicode.GetString(decrypted);
        }

        public static bool ComparePassword(string password, string password_encrypt)
        {
            string decrypted = Decrypt(password_encrypt);
            return (password == decrypted) ? true : false;
        }

        //Generating a ramdom number id
        public static string generateIdNumber()
        {
            var id_number = DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds.ToString().Split('.');
            return id_number[0];
        }

        //Generating a Barcode
        public static string GenerateBarcode(string code)
        {
            Barcode barcode = new Barcode();
            barcode.IncludeLabel = true;
            Image img = barcode.Encode(TYPE.CODE128, code, Color.Black, Color.White, 400, 100);
            string path = @"C:\GitProjects\Market\Market Manager\Resourses\barcode.png";            
            if (File.Exists(path))
            {
                File.Delete(path);
                img.Save(path, ImageFormat.Png);
            }
            else
            {
                img.Save(path, ImageFormat.Png);
            }
            return path;
        }

        //Generating a QrCode
        public static Image GenerateQrCode(string code)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(code, out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemp = new Bitmap(ms);
            var image = new Bitmap(imageTemp, new Size(100, 100));
            return image;
        }

    }
}
