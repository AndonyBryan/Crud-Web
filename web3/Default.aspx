<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="web3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-4">
        <h2 class="text-center">Gestión de Contactos</h2>




     



<asp:MultiView ID="multiView" runat="server" ActiveViewIndex="0" OnActiveViewChanged="multiView_ActiveViewChanged">
    <asp:View ID="viewHome" runat="server">
   

        <div class="row">
            <div class="col-md-12 mt-4">
             

            </div>
        </div>
    </asp:View>
 <asp:View ID="viewProfile" runat="server">
   

    <div class="row content-container">
        <div class="col-md-12 mt-4">
         
            <asp:Label runat="server" ID="lblProfileName"></asp:Label>
            <asp:Label runat="server" ID="lblProfileCarrera"></asp:Label>
        </div>
    </div>
</asp:View>

    <asp:View ID="viewContact" runat="server">
        
        <div class="row">
            <div class="col-md-12 mt-4">
                
            </div>
        </div>
    </asp:View>
</asp:MultiView>

<ul class="nav nav-pills nav-fill gap-2 p-1 small bg-primary rounded-5 shadow-sm" id="pillNav2" role="tablist" style="--bs-nav-link-color: var(--bs-white); --bs-nav-pills-link-active-color: var(--bs-primary); --bs-nav-pills-link-active-bg: var(--bs-white);">
    <li class="nav-item" role="presentation">
        <asp:Button runat="server" ID="homeTabButton" CssClass="nav-link active rounded-5" OnClientClick="return changeTab('home');" Text="Home" />
    </li>
    <li class="nav-item" role="presentation">
        <asp:Button runat="server" ID="profileTabButton" CssClass="nav-link rounded-5" OnClientClick="return changeTab('profile');" Text="Profile" />
    </li>
    <li class="nav-item" role="presentation">
        <asp:Button runat="server" ID="contactTabButton" CssClass="nav-link rounded-5" OnClientClick="return changeTab('contact');" Text="Contact" />
    </li>
</ul>



       

        <!-- Encabezado adicional -->
        <div class="row">
            <div class="col-md-12">
                <div class="alert alert-info" role="alert">
                    Bienvenido al sistema de gestión de contactos. Aquí puedes agregar, actualizar, eliminar y buscar contactos.
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-xs-12 col-sm-3">
                <div class="form-group">
                    Matricula
                    <asp:TextBox ID="textmatricula" runat="server" CssClass="form-control" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </div>
            </div>
            <div class="col-xs-12 col-sm-3">
                <div class="form-group">
                    <label for="textnombre">Nombre</label>
                    <asp:TextBox ID="textnombre" runat="server" CssClass="form-control" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                </div>
            </div>
            <div class="col-xs-12 col-sm-3">
                <div class="form-group">
                    Carrera
                    <asp:TextBox ID="textcarrera" runat="server" CssClass="form-control" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                </div>
            </div>
            <div class="col-xs-12 col-sm-3">
                <div class="form-group mt-4">
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" OnClick="Button1_Click" Text="Agregar" />
                    <asp:Button ID="Button2" runat="server" CssClass="btn btn-success" OnClick="Button2_Click" Text="Actualizar" />
                    <asp:Button ID="Button3" runat="server" CssClass="btn btn-danger" OnClick="Button3_Click" Text="Eliminar" />
                    <asp:Button ID="Button4" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="Button4_Click" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 mt-4">
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-striped">
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
