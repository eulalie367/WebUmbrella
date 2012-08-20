var Master = require("./master.js");

var master = function()
{
	var m = new Master();
	
	m.page = new function()
	{
		this.heading = 
		{
			title: "Article Title -- page.heading.title",
			text: "Article Text -- page.heading.text"
		}

		this.sections = 
		[
			{ title: "Section Title -- #page.sections > title", text: "Section Text -- #page.sections > text" }
		];

		this.footer = 
		{
			title: "Article Footer Title -- page.footer.title",
			text: "Article Footer Text -- page.footer.text"
		}
				
		this.aside = function()//need to make this a partial
		{
			return new master();
		}

		return this;
	}
		
	return m;
}

module.exports = master;


