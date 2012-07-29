<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- multiple h1 tags are valid in html5 within and article tag -->
    <header>
        <h1><%: ViewData["Message"] %></h1>
    </header>
    <section>
        <h2>Initializr and MVC2 Meet</h2>
        <p>This is a project that combines standards on both sides of the code...</p>
    </section>
    <footer>
        <ul>
            <li>
                To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
            </li>
            <li>
                To learn more about Initializr visit <a href="http://www.initializr.com/" title="Initilizr Website">http://www.initializr.com/</a>.
            </li>
        </ul>
    </footer>
</asp:Content>
