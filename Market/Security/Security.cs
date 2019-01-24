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
            byte[] salt;
            byte[] buffer;
            if (plain_text == null)
            {
                throw new ArgumentNullException(nameof(plain_text));
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(plain_text, 16, 1000))
            {
                salt = bytes.Salt;
                buffer = bytes.GetBytes(32);
            }
            byte[] dst = new byte[49];
            Buffer.BlockCopy(salt, 0, dst, 1, 16);
            Buffer.BlockCopy(buffer, 0, dst, 17, 32);

            return Convert.ToBase64String(dst);
        }


        //Comparing paswords 
        public static bool ComparePassword(string password, string password_encrypt)
        {
            byte[] buffer4;
            if (password_encrypt == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            byte[] src = Convert.FromBase64String(password_encrypt);
            if (src.Length != 49 || src[0] != 0)
            {
                return false;
            }
            byte[] dst = new byte[16];
            Buffer.BlockCopy(src, 1, dst, 0, 16);
            byte[] buffer3 = new byte[32];
            Buffer.BlockCopy(src, 17, buffer3, 0, 32);

            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 1000))
            {
                buffer4 = bytes.GetBytes(32);
            }
            return buffer3.SequenceEqual(buffer4);
        }

        //Generating a ramdom number id
        public static string generateIdNumber()
        {
            var id_number = DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds.ToString().Split('.');
            return id_number[0];
        }

        //Generating a Barcode
        public static Image GenerateBarcode(string code)
        {
            Barcode barcode = new Barcode();
            barcode.IncludeLabel = true;
            return barcode.Encode(TYPE.CODE128, code, Color.Black, Color.White, 400, 100);
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
