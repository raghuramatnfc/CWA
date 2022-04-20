'
' Created by SharpDevelop.
' User: RAGHU
' Date: 19-12-2016
' Time: 12:21
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
imports System.Xml
imports System.Xml.XPath
imports System.Xml.Linq
Imports System.Data


Imports MySql.Data.MySqlClient

Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Windows.Forms
Imports System.Data.SqlClient


Partial Class frmlogin
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.button3 = New System.Windows.Forms.Button()
		Me.groupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(52, 59)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(68, 15)
		Me.label1.TabIndex = 0
		Me.label1.Text = "User Name"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(57, 98)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(59, 15)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Password"
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(189, 54)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(264, 23)
		Me.textBox1.TabIndex = 1
		'
		'textBox2
		'
		Me.textBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.Location = New System.Drawing.Point(189, 93)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.textBox2.Size = New System.Drawing.Size(264, 23)
		Me.textBox2.TabIndex = 2
		AddHandler Me.textBox2.TextChanged, AddressOf Me.TextBox2TextChanged
		'
		'groupBox1
		'
		Me.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.groupBox1.Controls.Add(Me.button3)
		Me.groupBox1.Controls.Add(Me.label5)
		Me.groupBox1.Controls.Add(Me.comboBox1)
		Me.groupBox1.Controls.Add(Me.button2)
		Me.groupBox1.Controls.Add(Me.button1)
		Me.groupBox1.Controls.Add(Me.textBox2)
		Me.groupBox1.Controls.Add(Me.textBox1)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.Location = New System.Drawing.Point(309, 133)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(583, 265)
		Me.groupBox1.TabIndex = 4
		Me.groupBox1.TabStop = false
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(57, 130)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(46, 15)
		Me.label5.TabIndex = 6
		Me.label5.Text = "Project"
		Me.label5.Visible = false
		'
		'comboBox1
		'
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Location = New System.Drawing.Point(189, 122)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(264, 23)
		Me.comboBox1.TabIndex = 5
		Me.comboBox1.Visible = false
		'
		'button2
		'
		Me.button2.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.button2.FlatAppearance.BorderSize = 2
		Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.button2.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.button2.Location = New System.Drawing.Point(259, 165)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(83, 34)
		Me.button2.TabIndex = 4
		Me.button2.Text = "&Reset"
		Me.button2.UseVisualStyleBackColor = false
		'
		'button1
		'
		Me.button1.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.button1.FlatAppearance.BorderSize = 2
		Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.button1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.button1.Location = New System.Drawing.Point(370, 165)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(83, 34)
		Me.button1.TabIndex = 3
		Me.button1.Text = "&Login"
		Me.button1.UseVisualStyleBackColor = false
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label3.Location = New System.Drawing.Point(309, 103)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(583, 27)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Login"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label3.Click, AddressOf Me.Label3Click
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.label4.Location = New System.Drawing.Point(309, 392)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(583, 27)
		Me.label4.TabIndex = 6
		Me.label4.Text = "@Copy Right Zensar"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		AddHandler Me.label4.Click, AddressOf Me.Label4Click
		'
		'button3
		'
		Me.button3.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.button3.FlatAppearance.BorderSize = 2
		Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.button3.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.button3.Location = New System.Drawing.Point(370, 165)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(129, 34)
		Me.button3.TabIndex = 7
		Me.button3.Text = "Select Project"
		Me.button3.UseVisualStyleBackColor = false
		Me.button3.Visible = false
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'frmlogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.ClientSize = New System.Drawing.Size(979, 528)
		Me.ControlBox = false
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.groupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmlogin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler Load, AddressOf Me.FrmloginLoad
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private button3 As System.Windows.Forms.Button
	Private label5 As System.Windows.Forms.Label
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	
	Sub Button1Click(sender As Object, e As EventArgs)

 
		'Validate User Credentials
		Call validateuserlogin()
		
		
 	End Sub 
		
Public Sub validateuserlogin()
			Dim objConn As MySqlConnection
Dim objDataset As New DataSet
Dim objDataAdapter As MySqlDataAdapter
Dim objDatasetc As New DataSet
Dim objDataAdapterc As MySqlDataAdapter
Dim sqlConn As String
Dim sqlConnc As String
			try
		 
			If trim(textbox1.text).length =0 or trim(textbox1.text).length =0 Then 
				msgbox("Please Enter Credntials", VBCritical+VbOKOnly,"Login")
				Exit Sub
			Else
				Dim sqlDataAdapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim bSource As New BindingSource
    
  
    Try
    	Vari.sqlconn()
    	msgbox("select B.ProjectName,P.Role from users P,Projects B where P.UserName= " & "'" & trim(TextBox1.text) & "'" & " and " & " P.Password= " & "'" & TextBox2.Text & "'" &  " and " & "P.Projects=B.Project_ID" & ";"  )
        Vari.sqlcommand = New MySqlCommand("select B.ProjectName,P.Role from users P,Projects B where P.UserName= " & "'" & trim(TextBox1.text) & "'" & " and " & " P.Password= " & "'" & TextBox2.Text & "'" &  " and " & "P.Projects=B.Project_ID" & ";" , conn)
        sqlDataAdapter.SelectCommand = sqlcommand
        sqlDataAdapter.Fill(dt)
        If dt.rows.count=0 Then 
        	Msgbox("Invalid Login Credentials",VBCritical+VBOkOnly)
        	Exit Sub
        Else
        	 bSource.DataSource = dt
        'datagrid_Subject.DataSource = bSource
        sqlDataAdapter.Update(dt)
        
        comboBox1.DataSource=bSource
      
  With ComboBox1
    .DisplayMember = "ProjectName"
    .ValueMember = "Role"
    .DataSource = dt
  End With
  button3.visible=true
  ComboBox1.visible=True
  Label5.visible=true
        conn.Close()
        End If
    	       
    Catch ex As Exception
        MessageBox.Show(ex.Message)
    Finally

        Vari.conn.Dispose()
    End Try	
	
			End If
			Catch ex As Exception
            MsgBox(ex.Message)
        End Try
		End Sub
		
		
Public Sub playground()		
		  
		mainform.DgView.Visible=True
		mainform.button10.Visible=True
		mainform.button11.Visible=True
		mainform.button12.Visible=True
		mainform.button13.Visible=True
		mainform.button14.Visible=True
		mainform.button15.Visible=True
		mainform.button16.Visible=True
		mainform.textBox4.Visible=True
		mainform.splitContainer1.Panel1.visible=True
		setup.populateBaseNodes(mainform.tvcommands,mainform.imageList1,"C:\Users\RAGHU\Desktop\Commands\Commands.xml")
		'setup.loaddata(mainform.tvProjects,"Select projectname from projects",mainform.imageList2)
		Vari.selectedpt=comboBox1.Text
		bdisplaymaintree()
		displaymaintree()
		Vari.userrights=comboBox1.SelectedValue
		msgbox(Vari.userrights)
		If Vari.userrights=1 Then			
			mainform.toolStripButton8.visible=true
		Else If Vari.userrights=5 Then
			mainform.tvCompg.visible=true
			
		Else If Vari.userrights=6 Then
			mainform.tvCompg.visible=false
		End If
		loaddata(mainform.tvObjects,"select distinct(Value) from testobjects where Project_ID='" & Vari.selectedp & "'" & " and " &  "Display=1",mainform.imageList1,"TestObjects")
		loaddata(mainform.tvData,"select distinct(Name) from testdata where Project_ID='" & Vari.selectedp & "'" & " and " &  "Display=1",mainform.imageList1,"Project Specific TestData")
		loaddata(mainform.tvComp,"select distinct(ComponentName) from components where Project_ID='" & Vari.selectedp & "'" & " and " &  "Display=1",mainform.imageList1,"components")
		loaddata(mainform.tvCompg,"select distinct(ComponentName) from gcomponents where Project_ID='" & Vari.selectedp & "'" & " and " &  "Display=1",mainform.imageList1,"Global components")
		loaddata(mainform.tvVariables,"select distinct(Value) from testvars where Project_ID='" & Vari.selectedp & "'" & " and " &  "Display=1",mainform.imageList1,"TestObjects")
		
		
        Vari.cuser = textBox1.text 	
		'DgView.RowCount=26
		mainform.textBox4.Text="Test Case Name"
		setup.displaytooltip()
		mainform.menuStrip1.Visible=true
		mainform.toolStrip1.Visible=true
		
		 
	
		me.dispose()
	End Sub
	
	Public Sub bdisplaymaintree()
		Dim objConn As MySqlConnection
Dim objDataset As New DataSet
Dim objDataAdapter As MySqlDataAdapter
Dim objDatasetc As New DataSet
Dim objDataAdapterc As MySqlDataAdapter
Dim sqlConn As String
Dim sqlConnc As String
Try
mainform.tvProjects.Nodes.Clear	
objConn = New MySqlConnection("server=localhost;user id=root;password=raghu1976%;database=final1")
objConn.Open()
sqlConn = "SELECT Project_ID  from final1.projects where  ProjectName=" & "'" & Vari.selectedpt & "'" & " and" & " Display=1" &";"


objDataAdapter = New MySqlDataAdapter(sqlConn, objConn)
objDataAdapter.Fill(objDataset, "tblts")
objConn.Close()

Vari.selectedp=objDataset.Tables("tblts").Rows(0).Item(0).ToString



Catch ex As Exception
        MessageBox.Show(ex.Message)
    finally
        objConn=Nothing 
    End Try	
	End Sub
	
	
	Sub Label3Click(sender As Object, e As EventArgs)
		
	End Sub
	Public Sub displaymaintree()
	
Dim objConn As MySqlConnection
Dim objDataset As New DataSet
Dim objDataAdapter As MySqlDataAdapter
Dim objDatasetc As New DataSet
Dim objDataAdapterc As MySqlDataAdapter
Dim sqlConn As String
Dim sqlConnc As String
Try
mainform.tvProjects.Nodes.Clear	
objConn = New MySqlConnection("server=localhost;user id=root;password=raghu1976%;database=final1")
objConn.Open()
sqlConn = "SELECT distinct(Suite_Name) from final1.testsuitesnew where  Project_ID=" & "'" & Vari.selectedp & "'" & " and" & " Display=1" &";"


objDataAdapter = New MySqlDataAdapter(sqlConn, objConn)
objDataAdapter.Fill(objDataset, "tblts")
'MsgBox("The Connection is Now 'OPEN'")
'MsgBox(objDataset.Tables("tblts").Rows.Count-1)
objConn.Close()
'MsgBox("The Connection is Now 'CLOSE'")
Dim NodeName As String

mainform.tvProjects.ImageList=mainform.imageList1
mainform.tvProjects.Nodes.Add(Vari.selectedpt)
mainform.tvProjects.Nodes(0).ImageIndex=0
'tvProjects.SelectedNode.SelectedImageIndex=0
For i=0 To objDataset.Tables("tblts").Rows.Count-1
NodeName=objDataset.Tables("tblts").Rows(i).Item(0).ToString
mainform.tvProjects.Nodes(0).Nodes.Add(objDataset.Tables("tblts").Rows(i).Item(0).ToString)
mainform.tvProjects.Nodes(0).Nodes(i).ImageIndex=1

sqlConnc="select testcasename from testcases where Testcases_id in" & "(" & "select Testcase_ID from testsuitesnew where Project_ID=" & Vari.selectedp & " and Suite_name=" & "'" & NodeName & "'" & " and " & "display=" & "'" & "1" & "'" &");"

'MsgBox("select testcasename from testcases where Testcases_id in" & "(" & "select Testcase_ID from testsuitesnew where Project_ID=" & Vari.selectedp & " and Suite_name=" & "'" & NodeName & "'" & " and " & "display=" & "'" & "1" & "'" &");")
	objDataAdapterc = New MySqlDataAdapter(sqlConnc, objConn)
	objDataAdapterc.Fill(objDatasetc, "tblc")
	For j=0 To objDatasetc.Tables("tblc").Rows.Count-1
		mainform.tvProjects.Nodes(0).Nodes(i).Nodes.Add(New TreeNode(objDatasetc.Tables("tblc").Rows(j).Item(0).ToString))
		mainform.tvProjects.Nodes(0).Nodes(i).Nodes(j).ImageIndex=2
		'tvProjects.SelectedNode.SelectedImageIndex=2
		
'progressBar1.Value=j
		
	Next
objDatasetc.Clear
Next 	

Catch ex As Exception
        MessageBox.Show(ex.Message)
    finally
        objConn=Nothing 
    End Try	

	End Sub
	
	
	
	Sub Button3Click(sender As Object, e As EventArgs)
				'Validate User Credentials
		call playground()
		Textbox1.enabled=False
		Textbox2.enabled=False
        
	End Sub
End Class
