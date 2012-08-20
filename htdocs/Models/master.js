var mvc = require("mvc");

module.exports = function()
{
	this.Title = "Node.js MVC";
	this.Description = "Custom Node.js MVC implementation.";
	this.Author = "Patrick Herrington (patrick.herrington.netdeveloper@gmail.com)"
	this.Viewport = "width=device-width,initial-scale=1,maximum-scale=1,minimum-scale=1,user-scalable=no";
	this.GoogleAnalytics = "UA-XXXXX-X";
	
	
	this.Menu = new function()
	{
		return mvc.SiteMap();
	}

	return this;
}
