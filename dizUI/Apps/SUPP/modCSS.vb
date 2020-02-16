Module modCSS
    'this module is using for Child Form controls formatting
    Public FormTitleSize As Single = 10.0!
    Public FormTitleFont As Font = New System.Drawing.Font("Tahoma", 10.0!)
    Public FormTitleForecolor As Color = Color.White
    Public FormButtonOK As Color = Color.FromArgb(156, 207, 49) 'OK,Save,Review,Verify
    Public FormButtonCancel As Color = Color.FromArgb(255, 99, 71) 'Cancel,Delete,Pending
    Public FormButtonPrint As Color = Color.FromArgb(66, 66, 66) 'Print,Preview
    Public FormButtonNormal As Color = Color.FromArgb(66, 66, 66) 'NormalState

    Public AppsButtonDown As Color = Color.FromArgb(124, 252, 0)
    Public AppsButtonHover As Color = Color.FromArgb(144, 238, 144)
    Public AppsButtonNormal As Color = Color.Transparent
    Public AppsButtonSpDown As Color = Color.FromArgb(124, 252, 0)
    Public AppsButtonSpHover As Color = Color.FromArgb(144, 238, 144)
    Public AppsButtonSpNormal As Color = Color.Transparent
    Public AppsXDown As Color = Color.FromArgb(178, 34, 34)
    Public AppsXHover As Color = Color.FromArgb(255, 99, 71)
    Public AppsXNormal As Color = Color.Transparent

    Public entryDisabled As Color = Color.FromArgb(255, 192, 192)
    Public entryEnabled As Color = Color.FromArgb(192, 255, 192)
End Module
