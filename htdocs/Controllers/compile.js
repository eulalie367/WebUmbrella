var logger = require("winston")
	ext = require("../node_modules/mvc/ext"),
	less = require("less");

var compile = {};
var lessDir = "./less/";
var lessFiles = [];
compile.less = function(request, response, templates, callback, args)
{
	//TODO: fix this it is ugly
	templates = templates.pop();//make sure to remove the current template from templates; this is normally handled in the framework, but we are overriding the framework functionality

	if(typeof(args) != "undefined")
	{
		var fileName = lessDir + args.join("/") + ".less";
		if(typeof(lessFiles[fileName]) == "undefined" || lessFiles[fileName] == null)
		{
			ext.getFile(fileName, function(file)
			{
				if(file != null)
				{
					var parser = new(less.Parser)({
						 paths: [lessDir], // Specify search paths for @import directives
						 filename: 'style.less' // Specify a filename, for better error messages
					});

					parser.parse(file, function (e, tree) 
					{
						var css = tree.toCSS({ compress: true }); // Minify CSS output

						response.writeHead(200,
						{
							"Content-Type": "text/css"
						});
						lessFiles[fileName] = css;
						response.write(css);
						response.end();
						return;
					});
				}
			});
		}
		else
		{
			response.writeHead(200,
			{
				"Content-Type": "text/css"
			});
			response.write(lessFiles[fileName]);
			response.end();
			return;
		}
	}
	
}

module.exports = compile;

