var mvc = require("mvc");


mvc.server.port = 80;
mvc.server.debug = true;
mvc.server.excludes += "|app.js";
mvc.server.defaultPath = "home";

mvc.view.templateExtension = ".mu";
mvc.view.templates.push("shared/initilizr");

mvc.server.start();


