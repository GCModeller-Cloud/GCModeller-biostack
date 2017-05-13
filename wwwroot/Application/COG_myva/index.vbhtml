<!DOCTYPE html>
<html>
<head>
    <%= ../../includes/head.vbhtml %>
    <%= ../../includes/breadcrumb/styles.vbhtml %>

    <?vb $title = "COG myva online annotation" ?>
    <?vb $active2 = "active" ?>
    <?vb $appname = "COG myva analysis" ?>
</head>
<body>

    <div id="main-wrapper">

        <%= ../../includes/navigation-bar.vbhtml %>

        <div class="row">
            <div class="small-12 columns">
                <h1>COG myva</h1>

                <form method="POST" enctype="multipart/form-data" action="/Application/COG_myva/COG_myva.vbs">
                    <fieldset>
                        <legend>
                            Enter Query Sequence
                        </legend>
                        Paste your sequence in FASTA format:<br /><br />
                        <p>
                            <textarea name="fasta.text" placeholder="Input protein sequence in FASTA format." rows="15"></textarea>
                            Or upload your protein fasta:
                            <input name="fasta.file" type="file"></input>
                        </p>
                    </fieldset>

                    <fieldset>
                        <legend>
                            blast+ Parameters
                        </legend>
                        E-value: <input name="evalue" type="text"></input>
                        WordSize: <input name="wordsize" type="text"></input>
                        matrix:<input name="blastp.matrix" type="file"></input>
                    </fieldset>
                    
                    <fieldset>
                        <legend>
                            Export parameters:
                        </legend>
                        Identities: <input name="identities" type="text"></input>
                        Coverage: <input name="coverage" type="text"></input>
                    </fieldset>
                    
                    <button align="center" name="submit">Run Annotation</button>
                </form>

                <%= ../../includes/breadcrumb/applications.vbhtml %>
            </div>
        </div>

        <%= ../../includes/footer.vbhtml %>

    </div>
</body>
</html>