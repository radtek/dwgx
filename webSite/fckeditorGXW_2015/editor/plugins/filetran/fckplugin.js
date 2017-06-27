var FileTransferCommand=function(){};

FileTransferCommand.GetState=function() { return FCK_TRISTATE_OFF; }

FileTransferCommand.Execute=function() {
  if ( typeof( window.parent.FCKeditor_OnFileTransfer ) == 'function' )
    window.parent.FCKeditor_OnFileTransfer( FCK ) ;
}

// Register the related command.
//FCKCommands.RegisterCommand( 'rainbow', new FCKDialogCommand( 'rainbow', FCKLang.RainbowDlgTitle, FCKPlugins.Items['rainbow'].Path + 'rainbowText.html', 340, 160 ) ) ;
FCKCommands.RegisterCommand( 'filetran', FileTransferCommand ) ;

// Create the "rainbow" toolbar button.
var oFileTransferTextItem = new FCKToolbarButton( 'filetran', FCKLang.FileTransBtn ) ;
oFileTransferTextItem.IconPath = FCKPlugins.Items['filetran'].Path + 'filetran.gif' ;

FCKToolbarItems.RegisterItem( 'filetran', oFileTransferTextItem ) ;
