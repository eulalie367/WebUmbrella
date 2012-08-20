<!doctype html>
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js" lang="en"> <!--<![endif]-->
<head>
	<meta charset="utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />

	<title>{{ Title }}</title>
	<meta name="description" content="{{Description}}" />
	<meta name="author" content="{{Author}}" />

	<meta name="viewport" content="{{Viewport}}" />

	<link rel="stylesheet/less" href="/less/style.less" />
	<script type="text/javascript" src="/js/libs/less-1.3.0.min.js"></script>
	
	<!-- Use SimpLESS (Win/Linux/Mac) or LESS.app (Mac) to compile your .less files
	to style.css, and replace the 2 lines above by this one:

	<link rel="stylesheet" href="less/style.css">
	 -->

	<script type="text/javascript" src="/js/libs/modernizr-2.5.3-respond-1.1.0.min.js"></script>
</head>
<body>
<!--[if lt IE 7]><p class=chromeframe>Your browser is <em>ancient!</em> <a href="http://browsehappy.com/">Upgrade to a different browser</a> or <a href="http://www.google.com/chromeframe/?redirect=true">install Google Chrome Frame</a> to experience this site.</p><![endif]-->

	<div id="header-container">
		<header class="wrapper clearfix">
			<h1 id="title">{{ Title }}</h1>
			<nav>
				<ul>
					{{#Menu}}<!-- This needs to be a recursive partial -->
						<li>
							<a href="{{{path}}}">{{name}}</a>
							<!--  This Works, I just don't care to style it at the moment.
						  {{ #children }}
								<ul>
									<li>
										<a href="{{{path}}}">{{name}}</a>
										<ul>
										  {{ #children }}
												<li>
													<a href="{{{path}}}">{{name}}</a>
												</li>
										  {{ /children }}
										</ul>
									</li>
								</ul>
						  {{ /children }}
						  -->
						</li>
					{{/Menu}}
				</ul>
			</nav>
		</header>
	</div>
	<div id="main-container">
		<div id="main" class="wrapper clearfix">
			{{{ HTML }}}			
		</div> <!-- #main -->
	</div> <!-- #main-container -->

	<div id="footer-container">
		<footer class="wrapper"><!-- This needs to be a partial -->
			<h3>footer</h3>
		</footer>
	</div>

<script type="text/javascript" src="//ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<script type="text/javascript">window.jQuery || document.write('<script type="text/javascript" src="/js/libs/jquery-1.7.2.min.js"><\/script>')</script>

<!-- scripts concatenated and minified via ant build script type="text/javascript"-->
<script type="text/javascript" src="/js/plugins.js"></script>
<script type="text/javascript" src="/js/script.js"></script>
<!-- end scripts-->

<script type="text/javascript">
	var _gaq=[['_setAccount','{{GoogleAnalytics}}'],['_trackPageview']];
	(function(d,t){var g=d.createElement(t),s=d.getElementsByTagName(t)[0];
	g.src=('https:'==location.protocol?'//ssl':'//www')+'.google-analytics.com/ga.js';
	s.parentNode.insertBefore(g,s)}(document,'script'));
</script>

</body>
</html>


