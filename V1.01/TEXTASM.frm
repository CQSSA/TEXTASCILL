VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "TEXT TO ASCILL"
   ClientHeight    =   7470
   ClientLeft      =   6090
   ClientTop       =   9675
   ClientWidth     =   10215
   LinkTopic       =   "Form1"
   ScaleHeight     =   7470
   ScaleWidth      =   10215
   Begin VB.CommandButton Command2 
      Caption         =   "ASCILL TO TEXT"
      Height          =   915
      Left            =   1560
      TabIndex        =   5
      Top             =   6420
      Width           =   7035
   End
   Begin VB.CommandButton Command1 
      Caption         =   "TEXT TO ASCILL"
      Height          =   915
      Left            =   1560
      TabIndex        =   2
      Top             =   5280
      Width           =   7035
   End
   Begin VB.TextBox Text2 
      Height          =   1095
      Left            =   3180
      TabIndex        =   1
      Top             =   3660
      Width           =   3495
   End
   Begin VB.TextBox Text1 
      Height          =   1095
      Left            =   3180
      TabIndex        =   0
      Top             =   1500
      Width           =   3495
   End
   Begin VB.Label Label2 
      Caption         =   "ASCILL"
      BeginProperty Font 
         Name            =   "Î¢ÈíÑÅºÚ"
         Size            =   24
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   555
      Left            =   3180
      TabIndex        =   4
      Top             =   3060
      Width           =   1755
   End
   Begin VB.Label Label1 
      Caption         =   "TEXT"
      BeginProperty Font 
         Name            =   "Î¢ÈíÑÅºÚ"
         Size            =   24
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   555
      Left            =   3180
      TabIndex        =   3
      Top             =   900
      Width           =   1575
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim M2, M3, ASCNUM, FOR1 As Integer
Dim T1, T2, TEXTIN, ASCIN As String
Dim ASC1(99999) As String


 
Private Sub Command1_Click()
Erase ASC1
M2 = 0
M3 = 0
ASCNUM = 0
FOR1 = 0
T2 = ("")

 TEXTIN = Text1.Text
 T2 = ("/")

For M2 = 0 To Len(TEXTIN)
  If M2 >= 1 Then
     M3 = M3 + 1
     T1 = Mid(TEXTIN, M2, 1)
     T2 = T2 + Format(Asc(T1)) + ("/")
  End If
Next

Text2.Text = T2

End Sub

Private Sub Command2_Click()
Erase ASC1
M2 = 0
M3 = 0
ASCNUM = 0
FOR1 = 0
T2 = ("")

ASCIN = Text2.Text
  
  For M2 = 0 To Len(ASCIN)
  
  If M2 >= 1 Then
  
    If Mid(ASCIN, M2, 1) = ("/") Then
        ASCNUM = ASCNUM + 1

    Else
        ASC1(ASCNUM) = ASC1(ASCNUM) + Mid(ASCIN, M2, 1)
    End If
    
  End If
  Next
  FOR1 = 1

  
  For M2 = 0 To (ASCNUM - 2)
    
    T2 = T2 + Chr(ASC1(FOR1))
    FOR1 = FOR1 + 1
  Next

Text1.Text = T2
  
End Sub
