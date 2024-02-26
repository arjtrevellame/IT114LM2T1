<%@ Page Language="C#" CodeBehind="~/Exercise1.aspx.cs" Inherits="Module1Exercise1.Exercise1" %>

<%-- Exercise 1: Exploring Basic Controls of ASP.NET WebForms--%>
<%-- Useful References: https://www.tutorialspoint.com/asp.net/index.htm --%>
<!DOCTYPE html>
<html>
<head>
    <title>Malayan Music Player</title>
</head>
<body>
    <h1>Malayan Music Player</h1>
    <%-- !! IMPORTANT: Make sure to use the asp tag for each TODO  !! --%>
    <form runat="server">
        <%-- TODO 2.1 Create a label displaying the name of your favorite song and its artist (e.g. Yesterday - The Beatles)--%>
        <%-- Hint: https://www.tutorialspoint.com/asp.net/asp.net_custom_controls.htm#:~:text=Label --%>
        <asp:Label ID="favSong" runat="server" Text="Fix you - Coldplay"></asp:Label><br/>

        <%-- TODO 2.2 Create an image that is 200px by 200x big showing the album cover of your favorite song. Make sure to set the alternative text. --%>
        <%-- Hint: https://www.tutorialspoint.com/asp.net/asp.net_basic_controls.htm#:~:text=Image%20Control --%>
        <asp:Image ID="albumCover"  AlternateText="Fix you - Coldplay (Album Cover)" ImageUrl="https://images.genius.com/672199a304458160fbcc6072aa9042ca.1000x1000x1.jpg" runat="server" Height="200px" Width="200px" /><br />

        <%-- TODO 2.3 Create three buttons with texts. "Prev", "Play", and "Next" --%>
        <%-- Hint: https://www.tutorialspoint.com/asp.net/asp.net_basic_controls.htm#:~:text=Button%20Controls --%>
        <asp:Button ID="PrevBtn" Text="Prev" runat="server" />
        <asp:Button ID="PlayBtn" Text="Play" runat="server" OnClick="play_Click"/>
        <asp:Button ID="NextBtn" Text="Next" runat="server" />
        <br />
        <%-- TODO 2.4 Create a span. Once the play button is pressed, the span should display "Now playing <favorite song>" --%>
        <%-- Hint: https://www.tutorialspoint.com/asp.net/asp.net_first_example.htm#:~:text=convertoupper --%>
        <span id="displayPlaying" runat="server"></span>
        <script runat="server">
            void play_Click(object sender, EventArgs e)
            {
                displayPlaying.InnerText = "Now Playing "+ favSong.Text;
            }
        </script>
        <%-- TODO 2.5 Display the current time using the template syntax <%= %> --%>
        <br />
        <asp:Label runat="server" ID="timeStamp" ><%=DateTime.Now.ToString("hh:mm:ss tt") %></asp:Label>
    </form>
</body>
</html>
