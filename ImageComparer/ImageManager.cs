using System;
using System.IO;
using System.Security.Cryptography;

namespace ImageComparer
{
    public class ImageManager
    {
        public static bool CompareImages(string image1Path, string image2Path)
        {
            // Получаем хэши картинок с помощью функции GetImageHash
            var image1Hash = GetImageHash(image1Path);
            var image2Hash = GetImageHash(image2Path);

            // Сравниваем хэши
            return image1Hash == image2Hash;
        }

        private static string GetImageHash(string imagePath)
        {
            // Читаем картинку в поток
            using (var stream = new FileStream(imagePath, FileMode.Open))
            {
                // Создаем хэширующую функцию
                var sha1 = SHA1.Create();

                // Вычисляем хэш картинки
                var hash = sha1.ComputeHash(stream);

                // Конвертируем хэш в строку и возвращаем
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}
