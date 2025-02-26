using System.Drawing;
using System.Windows.Forms;

public class BaseForm : Form
{
    public BaseForm()
    {
        // D�finir le th�me noir pour toute l'application
        this.BackColor = Color.FromArgb(40, 40, 40); // Fond noir/gris fonc�
        this.ForeColor = Color.White; // Texte en blanc

        // D�finir une police par d�faut, si besoin
        this.Font = new Font("Arial", 10, FontStyle.Regular);

        // Vous pouvez d�finir d'autres propri�t�s par d�faut ici
        // Exemple : boutons, labels, etc.
    }
}
