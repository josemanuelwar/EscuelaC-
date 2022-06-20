namespace CoreEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            this.UniqueId = Guid.NewGuid().ToString();
            this.Nombre = "";
        }

        public override string ToString() {
            return $"{this.Nombre}, {this.UniqueId}";
        }
    }
}