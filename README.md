<p align="center">
  <a><img src="./ICON.png" width="250" height="250" /></a>

  <h2 align="center">Swift (Taylor's Version)</h2>
<h5 align="center">This is an esolang that transpiles to JavaScript. This isn't much of a serious project, more just a fun experiment. Create a `.stv` file and use the replacements while writing JavaScript code. Then use the transpiler in the command prompt!</h5>

---
### Replacements:

|.stv|.js|Info|
|--|--|--|
|speaknow|console.log|Album title, fitting name|
|glitter|let|The sparkly new pen, a 3-pen reference!|
|fountain|var|Another 3-pen reference!|
|quill|const|Another 3-pen reference!|
|delicate|if|The song title of the lyrics in cool and chill.|
|cool|else if|"Is it cool that I said all that?"|
|chill|else|"Is it chill that you're in my head?"|
|longlive|while|A song title that seemed fitting.|
|belongwithme|require|Another song title.|
|shortskirts|false|"She wears short skirts." This is not Taylor.|
|tshirts|true|"I wear T-Shirts." This is Taylor.|
|itwas|#800000|maroon...|

---
### Build Transpiler
The command to build the transpiler from this source is as follows:

`dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained`