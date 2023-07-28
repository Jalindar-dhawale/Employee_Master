<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeSalary.aspx.cs" Inherits="Employee_Master.EmployeeSalary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" ShowFooter="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="EMP_ID">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("EMP_ID") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtaddempid" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("EMP_ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="BASIC">
                        <EditItemTemplate>
                            <asp:TextBox ID="txteditbasic" runat="server" Text='<%# Bind("BASIC") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtaddbasic" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <HeaderTemplate>
                            BASIC
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("BASIC") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DA">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtupdateda" runat="server" Text='<%# Bind("DA") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtaddda" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("DA") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="HRA">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtupdatehra" runat="server" Text='<%# Bind("HRA") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtaddhra" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("HRA") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DEDUCTION">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtupdatededuction" runat="server" Text='<%# Bind("DEDUCTION") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtadddeduction" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("DEDUCTION") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="TOTAL">
                        <EditItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("TOTAL") %>'></asp:Label>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtaddtotal" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("TOTAL") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="COMMAND">
                        <EditItemTemplate>
                            <asp:Button ID="Button3" runat="server" CommandName="UPDATE" Text="UPDATE" />
                            <asp:Button ID="Button4" runat="server" CommandName="CANCLE" Text="CANCLE" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <div class="auto-style1">
                                <asp:Button ID="Button5" runat="server" CommandName="ADD" Text="ADD" />
                            </div>
                        </FooterTemplate>
                        <HeaderTemplate>
                            ACTION
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" CommandName="EDIT" Text="EDIT" />
                            <asp:Button ID="Button2" runat="server" CommandName="DELETE" Text="DELETE" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeedbConnectionString %>" SelectCommand="SELECT * FROM [EMP_SALARY_DTLS]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
