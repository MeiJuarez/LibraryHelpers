using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHelpers
{
    /// <summary>
    /// Clase ayudante de MessageTitle
    /// </summary>
    public class MessageBoxTitles
    {
        #region Constantes
        /// <summary>
        /// Titulo para información
        /// </summary>
        private static readonly string INFORMATION = "A V I S O";
        /// <summary>
        /// Titulo para advertencias
        /// </summary>
        private static readonly string WARNING = "A D V E R T E N C I A";
        /// <summary>
        /// Titulo  para preguntas
        /// </summary>
        private static readonly string QUESTION = "P R E G U N T A";
        /// <summary>
        /// Titulo de error
        /// </summary>
        private static readonly string ERROR = "E R R O R";
        #endregion

        #region Propiedades

        #endregion

        #region Contructor

        #endregion

        #region Eventos

        #endregion

        #region Estructuras

        /// <summary>
        /// Titulo para información
        /// </summary>
        public struct TitleInformation
        {
            /// <summary>
            /// Obtiene el mensaje
            /// </summary>
            /// <returns>
            /// returna el mensaje de información
            /// </returns>
            public static string GetMessage()
            {
                return INFORMATION;
            }
        }
        /// <summary>
        /// Titulo para advertencia
        /// </summary>
        public struct TitleWarning
        {
            /// <summary>
            /// Obtiene el mensaje
            /// </summary>
            /// <returns>
            /// returna el mensaje de advertencia
            /// </returns>
            public static string GetMessage()
            {
                return WARNING;
            }
        }
        /// <summary>
        /// Titulo para pregunta
        /// </summary>
        public struct TitleQuestion
        { /// <summary>
          /// Obtiene el mensaje
          /// </summary>
          /// <returns>
          /// returna el mensaje de pregunta
          /// </returns>
            public static string GetMessage()
            {
                return QUESTION;
            }
        }
        /// <summary>
        /// Titulo para error
        /// </summary>
        public struct TitleError
        {
            /// <summary>
            /// Obtiene el mensaje
            /// </summary>
            /// <returns>
            /// returna el mensaje de error
            /// </returns>
            public static string GetMessage()
            {
                return ERROR;
            }
        }

        #endregion

        #region Métodos privados

        #endregion

        #region Metodos públicos

        #endregion

    }
}