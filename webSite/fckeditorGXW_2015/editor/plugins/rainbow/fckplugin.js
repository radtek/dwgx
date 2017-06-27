var RainbowTextCommand=function(){};

//RainbowTextCommand.GetState=function() { return FCK_TRISTATE_OFF; }
RainbowTextCommand.GetState=function() { return __get__EditorText() != ''; }

RainbowTextCommand.Execute=function() { FCK.SetHTML(__rainbow(__get__EditorText())); }

function __get__EditorText() {
  var oEditor = FCK;
  var oDOM = oEditor.EditorDocument;
  var txt ;
  if ( document.all )
  {
    txt = oDOM.body.innerText ;
  }
  else	
  {
    var r = oDOM.createRange();
    r.selectNodeContents( oDOM.body );
    txt = r.toString();
  }
  return txt;
}


__hex = ['0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'];

function __To__hex(x)
{
  var high = x/16;
  var s = high+"";
  s = s.substring(0,2);
  high = parseInt(s,10);
  var left = __hex[high];
  var low = x-high*16;
  s = low+"";
  s = s.substring(0,2);
  low = parseInt(s,10);
  var right = __hex[low];
  var string = left+""+right;
  return string;
}

function __rainbow(text)
{
  color_d1 = 255;
  mul = color_d1/text.length;
  var s = [];
  for(i = 0; i<text.length; i++)
  {
    color_d1 = 255*Math.sin(i/(text.length/3));
    color_h1 = __To__hex(color_d1);
    color_d2 = mul*i;
    color_h2 = __To__hex(color_d2);
    s.push("<FONT COLOR = '#FF"+color_h1+color_h2+"'>"+text.substring(i,i+1)+'</FONT>');
  }
  return '<span style="background-color: #000000;">'+s.join('')+'</span>';
}


// Register the related command.
//FCKCommands.RegisterCommand( 'rainbow', new FCKDialogCommand( 'rainbow', FCKLang.RainbowDlgTitle, FCKPlugins.Items['rainbow'].Path + 'rainbowText.html', 340, 160 ) ) ;
FCKCommands.RegisterCommand( 'rainbow', RainbowTextCommand ) ;

// Create the "rainbow" toolbar button.
var oRainbowTextItem = new FCKToolbarButton( 'rainbow', FCKLang.RainbowBtn ) ;
oRainbowTextItem.IconPath = FCKPlugins.Items['rainbow'].Path + 'rainbow.gif' ;

FCKToolbarItems.RegisterItem( 'rainbow', oRainbowTextItem ) ;

