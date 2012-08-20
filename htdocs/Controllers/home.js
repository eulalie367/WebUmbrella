var Model = require("../Models/page.js");

var home = function(request, response, templates, callback)
{
	var m = new Model();
	
	m.page.sections.push({ title: "article section h2", text: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sodales urna non odio egestas tempor. Nunc vel vehicula ante. Etiam bibendum iaculis libero, eget molestie nisl pharetra in. In semper consequat est, eu porta velit mollis nec. Curabitur posuere enim eget turpis feugiat tempor. Etiam ullamcorper lorem dapibus velit suscipit ultrices. Proin in est sed erat facilisis pharetra." });

	callback(m, response, templates);
	
	return this;
}

module.exports = home;

