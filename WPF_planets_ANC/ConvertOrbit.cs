using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Globalization;
namespace NewListBox
{
    public class ConvertOrbit : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
        CultureInfo culture)
        {
            double orbit = (double)value;
            double factor = System.Convert.ToDouble(parameter,
            culture.NumberFormat); // Получаем форматирование для единиц измерения (зависит от настроек операционной системы по умолчанию, а именно от региона и региональных стандартов), parameter - получаем извне
            return Math.Pow(orbit / 40, 0.4) * 700 * factor; // Возводим выражение за запятой в степень 0.4, необходимо для определения положения в элементе управления в пикселях? определяет значения для положения по X и Y, 700 - размер окна, factor - получаем извне(parameter)
        }
        public object ConvertBack(object value, Type targetType, object parameter,
        CultureInfo culture)
        {
            throw new NotSupportedException("Этот метод не должен быть вызван");
        }
    }
}