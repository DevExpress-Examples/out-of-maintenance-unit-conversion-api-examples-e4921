#region #usings;
using DevExpress.UnitConversion;
using System.Diagnostics;
#endregion #usings

namespace UnitConversion_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #metricprefix
            // The pressure value is set to 760 mmHg.
            QuantityValue<Pressure> pressure = (760).MmHg();
            // Since it is a quantity value, it should be transformed to a proper measurement unit
            // to obtain a value for display or for comparison.
            // The pressure is obtained in Pascals and then converted into hectoPascals.
            MetricUnitsConverter prefixConverter = new MetricUnitsConverter();
            double pressure_in_hPa = prefixConverter.Convert(pressure.ToPascals(), MetricPrefix.None, MetricPrefix.Hecto);
            Debug.WriteLine(pressure_in_hPa);
            #endregion #metricprefix
        }
    }
}
