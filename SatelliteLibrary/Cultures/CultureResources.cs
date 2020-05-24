using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;
using System.Windows.Data;
using System.Windows.Forms;

namespace SatelliteLibrary.Cultures
{
    /// <summary>
    /// Wraps up XAML access to instance of WPFLocalize.Properties.Resources, list of available cultures, and method to change culture
    /// </summary>
    public class CultureResources
    {
        /// <summary>
        /// The Resources ObjectDataProvider uses this method to get an instance of the WPFLocalize.Properties.Resources class
        /// </summary>
        /// <returns></returns>
        public Properties.Resources GetResourceInstance()
        {
            return new Properties.Resources();
        }

        private static ObjectDataProvider m_provider;
        public static ObjectDataProvider ResourceProvider
        {
            get
            {
                if (m_provider == null)
                    m_provider = (ObjectDataProvider)System.Windows.Application.Current.FindResource("SatelliteResources");
                return m_provider;
            }
        }

        public static void ChangeCulture(CultureInfo culture)
        {
            Properties.Resources.Culture = culture;
            ResourceProvider.Refresh();
        }
    }
}
