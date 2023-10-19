using System;
using System.Windows.Forms;
using Componentes;

namespace Interface.VisualComponents
{
	public abstract class VisualPanel : Panel
	{
		#region Atributos
		private Componente _Componente;
		#endregion
		
		#region Propriedades
		public Componente Componente
		{
			get
			{
				return _Componente;
			}

			set
			{
				_Componente = value;
			}
		}

		#endregion

		public VisualPanel(Componente componente)
		{
			_Componente = componente;
			_Componente.Changed +=new Componentes.Componente.ChangedEventHandler(Componente_Changed);
		}

		protected abstract void Componente_Changed();
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint (e);
		}

	}
}
