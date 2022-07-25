namespace Skyjo
{
    internal class Carte
    {
        private int valeur;
        private bool visible;

        public Carte(int valeur, bool visible)
        {
            this.valeur = valeur;
            this.visible = visible;
        }

        public int getValeur()
        {
            return this.valeur;
        }

        public void swapVisibility()
        {
            if (this.visible)
            {
                this.visible = false;
            } else
            {
                this.visible = true;
            }
        }

        public void setVisibility(bool b)
        {
            this.visible = b;
        }

        public bool estVisible()
        {
            return this.visible;
        }
    }
}