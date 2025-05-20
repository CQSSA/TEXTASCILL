Option Explicit On
Public Class WINDOW
    Dim M2, M3, ASCNUM, FOR1 As Integer
    Dim T1, T2, TEXTIN, ASCIN As String
    Dim ASC1(99999999) As String
    Dim closeaira As Integer

    Declare Function ReleaseCapture Lib "user32" () As Long
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As IntPtr) As Long
    Private Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal hwnd As Long, ByVal crKey As Long, ByVal bAlpha As Byte, ByVal dwFlags As Long) As Long
    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    '窗口透明常数 AIR NUMMBER
    Const WS_EX_LAYERED = &H80000
    Const GWL_EXSTYLE = (-20)
    Const LWA_ALPHA = &H2
    Const LWA_COLORKEY = &H1
    '=====
    Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
    Private Const HWND_TOPMOST& = -1
    ' 将窗口置于列表顶部，并位于任何最顶部窗口的前面
    Private Const SWP_NOSIZE& = &H1
    ' 保持窗口大小
    Private Const SWP_NOMOVE& = &H2
    ' 保持窗口位置
    '窗口透明常数
    '=====
    Dim NUM1 As Double

    Private Sub WINDOW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rtn As Long
        Me.BackColor = System.Drawing.Color.FromArgb(158, 158, 158)  '设置一下窗口的颜色 SET WINDOW COLOR
        rtn = GetWindowLong(Me.Handle, GWL_EXSTYLE)
        rtn = rtn Or WS_EX_LAYERED
        SetWindowLong(Me.Handle, GWL_EXSTYLE, rtn)
        'SetWindowPos(Me.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        closeaira = 250
        SetLayeredWindowAttributes(Me.Handle, RGB(0, 0, 0), 250, LWA_ALPHA)  'WINDOW AIR

        

    End Sub
    Private Sub WINDOW_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed  'vb关闭事件 CLOSE WINDOW
        For numas As Integer = 0 To 150
            If closeaira > 1 Then
                SetLayeredWindowAttributes(Me.Handle, RGB(0, 0, 0), closeaira, LWA_ALPHA)
                closeaira = closeaira - 5
            End If
            Sleep(1)
        Next
    End Sub
    Private Sub TTOA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TTOA.Click
        Erase ASC1
        ReDim ASC1(99999999)
        M2 = 0
        M3 = 0
        ASCNUM = 0
        FOR1 = 0
        T2 = ("")

        TEXTIN = TIN.Text
        T2 = ("/")

        For Me.M2 = 0 To Len(TEXTIN)
            If M2 >= 1 Then
                M3 = M3 + 1
                T1 = Mid(TEXTIN, M2, 1)
                T2 = T2 + Format(Asc(T1)) + ("/")
            End If
        Next

        ASCI.Text = T2

    End Sub

    Private Sub ATOTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ATOTE.Click
        Erase ASC1
        ReDim ASC1(99999999)
        M2 = 0
        M3 = 0
        ASCNUM = 0
        FOR1 = 0

        T2 = ("")

        ASCIN = ASCI.Text

        For Me.M2 = 0 To Len(ASCIN)
            If M2 >= 1 Then
                If Mid(ASCIN, M2, 1) = ("/") Then
                    ASCNUM = ASCNUM + 1
                Else
                    ASC1(ASCNUM) = ASC1(ASCNUM) + Mid(ASCIN, M2, 1)
                End If
            End If
        Next

        FOR1 = 1

        For Me.M2 = 0 To (ASCNUM - 2)
            T2 = T2 + Chr(ASC1(FOR1))
            FOR1 = FOR1 + 1
        Next
        TIN.Text = T2
    End Sub

    Private Sub TIN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIN.TextChanged

    End Sub

    Private Sub ASC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASCI.TextChanged

    End Sub
End Class
