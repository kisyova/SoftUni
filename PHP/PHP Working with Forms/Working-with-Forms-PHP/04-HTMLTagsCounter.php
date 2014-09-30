<?php
session_start();
?>
<!DOCTYPE html>
    <html>
<title>HTML Tags Counter</title>
<head>
    <style type="text/css">
        .info {
            font-size: 30px;
            font-weight: bold;
            font-family: Tahoma;
        }
    </style>
</head>
<body>
<form method="post">
    <label for="tag">Enter HTML tag:</label><br><br>
    <input type="text" id="tag" name="tag">
    <input type="submit" name="submit"><br><br>

    <?php
    $tags = array("a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "blockquote", "body", "br", "button", "canvas", "caption",
        "cite", "code", "col", "colgroup", "command", "datalist", "dd", "del", "details", "dfn", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption", "figure",
        "footer", "form", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header", "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label",
        "legend", "li", "link", "map", "mark", "menu", "meta", "meter", "nav", "noscript", "object", "ol", "optgroup", "option", "output", "p", "param", "pre", "progress",
        "q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source", "span", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td",
        "textarea", "tfoot", "th", "thead", "time", "title", "tr", "track", "u", "ul", "var", "video", "wbr");

    if(!isset($_SESSION["score"]) || !isset($_SESSION["restTags"])) {
        $_SESSION["score"] = 0;
        $_SESSION["restTags"] = $tags;
    }

    if($_POST && isset($_POST["submit"])) {
        $tag = mb_strtolower(trim($_POST["tag"]));

        if(array_search($tag, $tags) === false) { ?>
            <div class="info">Invalid HTML tag!</div>
    <?php
        }
        else { ?>
            <div class="info">Valid HTML tag!</div>
    <?php
            if(array_search($tag, $_SESSION["restTags"]) !== false) {
                $_SESSION["score"]++;
                $key = array_search($tag, $tags);
                unset($_SESSION["restTags"][$key]);
            }
        }
    }
    ?>
    <div class="info">Score: <?php echo $_SESSION["score"]; ?></div>


</form>
</body>
    </html>