<div id="header-nav" class="contain-to-grid">	
	<nav class="top-bar" data-topbar="">
		
		<ul class="title-area">
			<li class="name">
				<h1><a href="/"><img alt="GCModeller Logo" src="/DNA.png" id="header-logo">Biostack</a></h1>
            </li>
            <li class="toggle-topbar"><a href="#">Menu</a></li>
        </ul>
                    
        <section class="top-bar-section">
		
            <!-- Right Nav Section -->
            <ul class="left">
				<li class="$active1"><a href="/"><i class="fa fa-home"></i> Home</a></li>
				<li class="$active2"><a href="/Download.vbhtml"><i class="fa fa-download"></i> Data Analysis</a></li>              
				<li class="$active3"><a href="/Help.vbhtml"><i class="fa fa-github"></i> Help</a></li>
            </ul>
			<ul class="right">
				<li class="has-form right">
					
					<script type="text/javascript">
						
						// 需要放在form的前面进行定义，否则会出现找不到函数的错误
						void function searchURL() {							
							var query = document.getElementById("bing").value;
								
							query = query + "+site%3Agcmodeller.org";
							query = "/biostack/search.vbs?q=" + query;								
							window.location = query;
						}							
					</script>
				
					<form id="header-searchform" onsubmit="javascript:searchURL();" method="get">
					
						<div class="row collapse">
							<div class="small-11 medium-9 large-10 columns">
								<input name="q" placeholder="Search..." type="text" id="bing">
								</input>
							</div>
							<div class="small-1 medium-3 large-2 columns">
								<button type="submit" class="postfix button">
									<i class="fa fa-search"></i>
								</button>
							</div>
						</div>					
						
					</form>
				</li>
			</ul>
        </section>
	</nav>
</div>