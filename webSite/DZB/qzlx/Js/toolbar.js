function ToolbarMouseEvent(obj, state)
{
  if (obj.className=='tbButtonDisabled') return;
  switch (state)
  {
      case 0:

          obj.style.backgroundImage = "url(/images/tb_bg_" + obj.width + ".gif)";
          obj.style.backgroundRepeat = "no-repeat";


          break;
      case 1: if (!obj.down || obj.down != 1) {
              obj.className = "tbButtonUp";
              obj.style.backgroundImage = "";
          } break;
  }
}

function GroupButtonDown(btn)
{
  var obj = document.getElementsByTagName('TD');
  for (var i=0; i<obj.length; i++)
    if (obj[i].groupindex == btn.groupindex)
    {
      obj[i].down = 0;
      obj[i].className = 'tbButtonUp';
    }
  btn.down = 1;
  btn.className='tbButtonDown';
}

function EnableButton(btn, enabled) { btn.className = (enabled?"tbButtonUp":"tbButtonDisabled"); }

function IsButtonEnabled(btn) {return btn.className!="tbButtonDisabled";}


function TabPageMouseEvent(obj, state)
{
  if (obj.className=='tabDisabled') return;
  switch (state)
  {
    case 0: obj.className="tabActived"; break;
    case 1: if (!obj.actived) obj.className=""; break;
  }
}
function ActiveTab(tab)
{
  var obj = document.getElementsByTagName('TD');
  for (var i=0; i<obj.length; i++)
  {
    obj[i].actived = 0;
    obj[i].className = '';
  }
  tab.actived = 1;
  tab.className='tabActived';
}

function IsTabDisabled(tab) {return tab.className!="tabDisabled";}