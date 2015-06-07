Class MainWindow 

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed

    End Sub

    Private Sub Image1_MouseEnter(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles Image1.MouseEnter
        'MsgBox("Hola")
        Dim bi3 As New BitmapImage
        bi3.BeginInit()
        bi3.UriSource = New Uri("/Probando%20WPF;component/Images/logo.png", UriKind.Relative)
        bi3.EndInit()
        Image1.Source = bi3


    End Sub

    

    Private Sub Image1_MouseLeave(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles Image1.MouseLeave
        Dim bi3 As New BitmapImage
        bi3.BeginInit()
        bi3.UriSource = New Uri("/Probando%20WPF;component/iosCustom114x2.png", UriKind.Relative)
        bi3.EndInit()
        Image1.Source = bi3
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim f = New MDIParent1
        f.ShowDialog()


    End Sub
End Class
