<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridCrud.aspx.cs" Inherits="Crud_Web_App.GridCrud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>

        * {
            overflow-x: hidden;
        }

        html, body {
            margin: 0;
            width: 100%;
            height: 100%;
            overflow-x: hidden;
            font-family: 'Comic Sans MS';
        }
         .center-y {
            width: 100%;
            height: 100%;
            display: flex;
            flex-direction: column;
            justify-content: center;
            overflow-x: scroll !important;
        }

        .center-x {
            width: 100%;
            display: flex;
            flex-direction: row;
            justify-content: center;
            overflow-x: hidden;
        }
    </style>
    <title></title>
</head>
<body>
    <div class="center-y">
        <div class="center-x">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>



                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Username"  HeaderText="Username"/>
                <asp:BoundField DataField="Password" HeaderText="Password"/>
                <asp:BoundField DataField="Email" HeaderText="Email"/>
                <asp:CommandField ButtonType="Button" DeleteText="Delete" ShowDeleteButton="true"  UpdateText="Update" ShowEditButton="true"
                    EditText="Edit" ShowCancelButton="true" CancelText="Cancel"/>
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>

                   <asp:Label ID="LabelInsertStatus"  runat="server" Text=""></asp:Label>


    </form>
            </div>
         </div>
</body>
</html>
