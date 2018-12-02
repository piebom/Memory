<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "austin_powers.gif")
        Me.ImageList1.Images.SetKeyName(1, "bart_simpson.gif")
        Me.ImageList1.Images.SetKeyName(2, "blutos.gif")
        Me.ImageList1.Images.SetKeyName(3, "bruce_springsteen.gif")
        Me.ImageList1.Images.SetKeyName(4, "bugs_bunny.gif")
        Me.ImageList1.Images.SetKeyName(5, "captain_haddock.gif")
        Me.ImageList1.Images.SetKeyName(6, "chaplin.gif")
        Me.ImageList1.Images.SetKeyName(7, "dupont.gif")
        Me.ImageList1.Images.SetKeyName(8, "einstein.gif")
        Me.ImageList1.Images.SetKeyName(9, "elvis_presley.gif")
        Me.ImageList1.Images.SetKeyName(10, "evolution.gif")
        Me.ImageList1.Images.SetKeyName(11, "felix.gif")
        Me.ImageList1.Images.SetKeyName(12, "garfield.gif")
        Me.ImageList1.Images.SetKeyName(13, "george_washington.gif")
        Me.ImageList1.Images.SetKeyName(14, "goofy.gif")
        Me.ImageList1.Images.SetKeyName(15, "hagar_viking.gif")
        Me.ImageList1.Images.SetKeyName(16, "homer_simpson.gif")
        Me.ImageList1.Images.SetKeyName(17, "julius_caesar.gif")
        Me.ImageList1.Images.SetKeyName(18, "leonard_de_vinci.gif")
        Me.ImageList1.Images.SetKeyName(19, "marsupilami.gif")
        Me.ImageList1.Images.SetKeyName(20, "micky_mouse.gif")
        Me.ImageList1.Images.SetKeyName(21, "ninja_turtles.gif")
        Me.ImageList1.Images.SetKeyName(22, "obelix.gif")
        Me.ImageList1.Images.SetKeyName(23, "pink_panther.gif")
        Me.ImageList1.Images.SetKeyName(24, "popeye.gif")
        Me.ImageList1.Images.SetKeyName(25, "robin_hood.gif")
        Me.ImageList1.Images.SetKeyName(26, "sherlock_holmes.gif")
        Me.ImageList1.Images.SetKeyName(27, "smurf.gif")
        Me.ImageList1.Images.SetKeyName(28, "snow_white.gif")
        Me.ImageList1.Images.SetKeyName(29, "spiderman.gif")
        Me.ImageList1.Images.SetKeyName(30, "sylvester_stalone.gif")
        Me.ImageList1.Images.SetKeyName(31, "tigger.gif")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Albania.png")
        Me.ImageList2.Images.SetKeyName(1, "Austria.png")
        Me.ImageList2.Images.SetKeyName(2, "Belgium.png")
        Me.ImageList2.Images.SetKeyName(3, "BosniaHerzegovina.png")
        Me.ImageList2.Images.SetKeyName(4, "Bulgaria.png")
        Me.ImageList2.Images.SetKeyName(5, "Croatia.png")
        Me.ImageList2.Images.SetKeyName(6, "CzechRepublic.png")
        Me.ImageList2.Images.SetKeyName(7, "Denmark.png")
        Me.ImageList2.Images.SetKeyName(8, "Finland.png")
        Me.ImageList2.Images.SetKeyName(9, "France.png")
        Me.ImageList2.Images.SetKeyName(10, "Germany.png")
        Me.ImageList2.Images.SetKeyName(11, "Greece.png")
        Me.ImageList2.Images.SetKeyName(12, "Hungary.png")
        Me.ImageList2.Images.SetKeyName(13, "Iceland.png")
        Me.ImageList2.Images.SetKeyName(14, "Ireland.png")
        Me.ImageList2.Images.SetKeyName(15, "Italy.png")
        Me.ImageList2.Images.SetKeyName(16, "Macedonia.png")
        Me.ImageList2.Images.SetKeyName(17, "Moldova.png")
        Me.ImageList2.Images.SetKeyName(18, "Montenegro.png")
        Me.ImageList2.Images.SetKeyName(19, "Netherlands.png")
        Me.ImageList2.Images.SetKeyName(20, "Norway.png")
        Me.ImageList2.Images.SetKeyName(21, "Poland.png")
        Me.ImageList2.Images.SetKeyName(22, "Portugal.png")
        Me.ImageList2.Images.SetKeyName(23, "Romania.png")
        Me.ImageList2.Images.SetKeyName(24, "Serbia.png")
        Me.ImageList2.Images.SetKeyName(25, "Slovakia.png")
        Me.ImageList2.Images.SetKeyName(26, "Slovenia.png")
        Me.ImageList2.Images.SetKeyName(27, "Spain.png")
        Me.ImageList2.Images.SetKeyName(28, "Sweden.png")
        Me.ImageList2.Images.SetKeyName(29, "Switzerland.png")
        Me.ImageList2.Images.SetKeyName(30, "Ukraine.png")
        Me.ImageList2.Images.SetKeyName(31, "UnitedKingdom.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 691)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
End Class
