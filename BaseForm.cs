using System.Drawing;
using System.Windows.Forms;

public class BaseForm : Form
{
    public BaseForm()
    {
        // Définir le thème noir pour toute l'application
        this.BackColor = Color.FromArgb(40, 40, 40); // Fond noir/gris foncé
        this.ForeColor = Color.White; // Texte en blanc

        // Définir une police par défaut, si besoin
        this.Font = new Font("Arial", 10, FontStyle.Regular);

        // Vous pouvez définir d'autres propriétés par défaut ici
        // Exemple : boutons, labels, etc.
    }
}
