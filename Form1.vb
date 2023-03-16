Public Class frmPrincipal

#Region "Atributos"
    Private _indiceEstados1 As Integer
    Private _indiceCapitales1 As Integer
    Private _indiceEstados2 As Integer
    Private _indiceCapitales2 As Integer

    Public Property IndiceEstados1 As Integer
        Set(value As Integer)
            If value <> _indiceEstados1 Then 'Validar que haya algun cambio en el valor
                _indiceEstados1 = value
            End If
        End Set
        Get
            Return _indiceEstados1
        End Get
    End Property

    Public Property IndiceEstados2 As Integer
        Set(value As Integer)
            If value <> _indiceEstados2 Then 'Validar que haya algun cambio en el valor
                _indiceEstados2 = value
            End If
        End Set
        Get
            Return _indiceEstados2
        End Get
    End Property

    Public Property IndiceCapitales1 As Integer
        Set(value As Integer)
            If value <> _indiceCapitales1 Then 'Validar que haya algun cambio en el valor
                _indiceCapitales1 = value
            End If
        End Set
        Get
            Return _indiceCapitales1
        End Get
    End Property

    Public Property IndiceCapitales2 As Integer
        Set(value As Integer)
            If value <> _indiceCapitales2 Then 'Validar que haya algun cambio en el valor
                _indiceCapitales2 = value
            End If
        End Set
        Get
            Return _indiceCapitales2
        End Get
    End Property

#End Region

#Region "Metodos"
    Private Sub inicializarComponentes()
        cmbCapitales1.SelectedIndex = 0              'Valor inicial del comboBox
        cmbCapitales2.SelectedIndex = 0              'Valor inicial del comboBox
        cmbEstados1.SelectedIndex = 0              'Valor inicial del comboBox
        cmbEstados2.SelectedIndex = 0              'Valor inicial del comboBox

        IndiceCapitales1 = cmbCapitales1.SelectedIndex
        IndiceEstados1 = cmbEstados1.SelectedIndex

        IndiceCapitales2 = cmbCapitales2.SelectedIndex
        IndiceEstados2 = cmbEstados2.SelectedIndex
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarComponentes()
    End Sub

    Private Sub cmbEstados1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstados1.SelectedIndexChanged
        IndiceEstados1 = cmbEstados1.SelectedIndex
        cmbCapitales1.SelectedIndex = IndiceEstados1
    End Sub

    Private Sub cmbCapitales2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCapitales2.SelectedIndexChanged
        IndiceCapitales2 = cmbCapitales2.SelectedIndex
        cmbEstados2.SelectedIndex = IndiceCapitales2
    End Sub

#End Region

End Class
