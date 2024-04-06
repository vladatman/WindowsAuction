using System.Drawing;
using System.Windows.Forms;

public class LotPanel : Panel
{
    private int originalWidth;
    private int originalHeight;
    private int shadowDepth = 5;
    private bool isMouseOver = false;

    public LotPanel()
    {
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        this.Padding = new Padding(shadowDepth); // Установить отступ для создания эффекта тени вокруг панели
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // Рисование тени
        var shadowColor = Color.FromArgb(100, Color.LightBlue);
        e.Graphics.FillRectangle(new SolidBrush(shadowColor), new Rectangle(0, 0, this.Width, this.Height));

        // Рисование внутреннего контента панели
        var clientRect = new Rectangle(shadowDepth, shadowDepth, this.Width - 2 * shadowDepth, this.Height - 2 * shadowDepth);
        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), clientRect);
    }
}
