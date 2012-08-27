var mvc = require("mvc"),
	logger = require("winston");

logger.add(logger.transports.File, { filename: 'server.log', json: false });


mvc.server.port = 8080;
mvc.server.debug = true;
mvc.server.defaultPath = "home";

mvc.view.templateExtension = ".mu";
mvc.view.templates.push("shared/initilizr");

logger.log("info", "starting server");
mvc.server.start();


