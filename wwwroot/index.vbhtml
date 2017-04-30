﻿<!DOCTYPE html>
<html>
	<%= ./includes/head.vbhtml %>
	<?vb $title = "Welcome to the GCModeller biostack platform" ?>
	<?vb $active1 = "active" ?>
<body>

	<div id="main-wrapper">
    
		<%= ./includes/navigation-bar.vbhtml %>
    
		<div class="row">
			<div class="small-12 columns">
				<h1>Biostack platform</h1>
				<h3>Navigate reference database</h3>
				<ul>
					<li><a href="./KEGG.vbhtml">KEGG reference database</a></li>
					<li><a href="./Uniprot.vbhtml">Uniprot Protein Reference database</a></li>
					<li><a href="./RegPrecise.vbhtml">RegPrecise Motif Reference database</a></li>
				</ul>
			</div>
		</div>
    
		<%= ./includes/footer.vbhtml %>

	</div>
	
</body>
</html>
