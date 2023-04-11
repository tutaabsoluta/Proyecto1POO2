using System.IO;

namespace ProyectoSergio
{
    internal class FormularioConStreamWriter
    {
        internal StreamWriter writer;
        private string v;

        public FormularioConStreamWriter(string v)
        {
            this.v = v;
        }
    }
}