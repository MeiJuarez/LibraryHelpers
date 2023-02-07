using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelpers
{
   public class ControlsHelper
    {
        #region Metodos

        /// <summary>
        /// Solo permite capturtar números
        /// </summary>
        /// <param name="keyChar"></param>
        /// <remarks>
        /// 03/02/2023, Autor ijuarez Creación.
        /// </remarks>
        public static bool SoloNumeros(char keyChar)
        {
            try
            {
                if (Char.IsDigit(keyChar) || Char.IsControl(keyChar))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
