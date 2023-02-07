using System.Windows.Forms;
namespace LibraryHelpers
{ 
	/// <summary>
	/// Clase ayudante de MesageBox
	/// </summary>
	public static class MessageBoxHelper
	{
	
		/// <summary>
		/// Muestra un cuadro de mensaje de ERROR
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <param name="buttons">Botones a Mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowError(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleError.GetMessage(), buttons, MessageBoxIcon.Hand);
		}

		/// <summary>
		/// Muestra un cuadro de mensaje de ERROR, con el boton de OK
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowError(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleError.GetMessage(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		/// <summary>
		/// Muestra un cuadro de mensaje de ERROR, con los botones de YES, NO
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowErrorYesNo(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleError.GetMessage(), MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
		}

		/// <summary>
		/// Muestra un cuadro de mensaje de ERROR, con el boton de OK y CANCEL
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowErrorOKCancel(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleError.GetMessage(), MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Question
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <param name="buttons">Botones a Mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowQuestion(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleQuestion.GetMessage(), buttons, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Question, con el boton de OK
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowQuestion(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleQuestion.GetMessage(), MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Question, con los botones de YES, NO
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowQuestionYesNo(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleQuestion.GetMessage(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Question, con el boton de OK y CANCEL
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowQuestionOKCancel(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleQuestion.GetMessage(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Warning
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <param name="buttons">Botones a Mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowWarning(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), buttons, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Warning, con el boton de OK
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowWarning(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Warning, con los botones de YES, NO
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowWarningYesNo(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Warning, con el boton de OK y CANCEL
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowWarningOKCancel(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Exclamation
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <param name="buttons">Botones a Mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowExclamation(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), buttons, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Exclamation, con el boton de OK
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowExclamation(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Exclamation, con los botones de YES, NO
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowExclamationYesNo(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Exclamation, con el boton de OK y CANCEL
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowExclamationOKCancel(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleWarning.GetMessage(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Information
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <param name="buttons">Botones a Mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowInformation(string text, MessageBoxButtons buttons)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleInformation.GetMessage(), buttons, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Information, con el boton de OK
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowInformation(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleInformation.GetMessage(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Information, con los botones de YES, NO
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowInformationYesNo(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleInformation.GetMessage(), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// Muesta un cuadro de mensaje de Information, con el boton de OK y CANCEL
		/// </summary>
		/// <param name="text">Texto a mostrar</param>
		/// <returns>Resultado del dialogo</returns>
		public static DialogResult ShowInformationOKCancel(string text)
		{
			return MessageBox.Show(text, MessageBoxTitles.TitleInformation.GetMessage(), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}
	}

}
