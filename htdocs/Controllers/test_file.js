var Model = require("../Models/page.js");

var templates = function(request, response, templates, callback)
{

	var m = new Model();
	m.Title = "Templates";
	templates[1] = "home/index";
	callback(m, response);
	
	return this;
}

templates.test = function(request, response, templates, callback)
{
	var m = new Model();
	m.Title = "Jame's Home";
	templates.pop();
	//callback(model, filename, response, ".mu");
	callback(m, response);

	return this;
}


templates.test.test = function(request, response, templates, callback)
{
	var m = new Model();
	m.Title = "/Hello/Test/Test";
	templates[1] = "home/index";
	callback(m, response);

	return this;
}





module.exports = templates;
exports.test = templates.test;
exports.test.test = templates.test.test;

