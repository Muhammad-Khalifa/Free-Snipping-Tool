!define PRODUCT_NAME "Free Snipping Tool"	
!define PRODUCT_EXENAME "Free Snipping Tool.exe"		
!define PRODUCT_VERSION "1.2" 			
!define PRODUCT_PUBLISHER ""	
!define PRODUCT_WEB_SITE "www.smart-arab.com"
!define PRODUCT_DESCRIPTION ""				
!define BRAND_TEXT "www.smart-arab.com"	

; MUI Settings / Header
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_RIGHT
!define MUI_HEADERIMAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Header\orange-r.bmp"
!define MUI_HEADERIMAGE_UNBITMAP "${NSISDIR}\Contrib\Graphics\Header\orange-uninstall-r.bmp"

; MUI Settings / Wizard
!define MUI_WELCOMEFINISHPAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Wizard\orange.bmp"
!define MUI_UNWELCOMEFINISHPAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Wizard\orange-uninstall.bmp"

!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXENAME}"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

!include "nsProcess.nsh"

; MUI 
!include "MUI.nsh"
; MUI Settings
!define MUI_ABORTWARNING
; MUI Settings / Icons
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\orange-install.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\orange-uninstall.ico"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; License page
;!insertmacro MUI_PAGE_LICENSE "c:\path\to\licence\YourSoftwareLicence.txt"
; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!define MUI_FINISHPAGE_RUN "$INSTDIR\${PRODUCT_EXENAME}"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "ENGLISH"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "${PRODUCT_NAME}_Setup.exe"
InstallDir "d:\${PRODUCT_NAME}"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails nevershow
ShowUnInstDetails show

BrandingText "${BRAND_TEXT}"

VIProductVersion "1.0.0.0"
VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductVersion" "${PRODUCT_VERSION}"
VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "${PRODUCT_NAME}"
VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "© Copyright ${PRODUCT_PUBLISHER}"
VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "Description "
VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "${PRODUCT_VERSION}"




Section Main

   ${nsProcess::KillProcess} "Suar Snipping Tool.exe" $R0
  ; Start Install
  SetOutPath "$INSTDIR"
  SetOverwrite on

  
  ; Main Exe File
  ;File "Files to Install\${PRODUCT_EXENAME}"
  File /r "Files to Install\*.*"

 
  ;RegDLL "$SYSDIR\myfile.dll"
   
  CreateDirectory "$SMPROGRAMS\${PRODUCT_NAME}"
  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk" "$INSTDIR\${PRODUCT_EXENAME}"
  CreateShortCut "$DESKTOP\${PRODUCT_NAME}.lnk" "$INSTDIR\${PRODUCT_EXENAME}"
  CreateShortCut "$SMPROGRAMS\Startup\${PRODUCT_NAME}.lnk" "$INSTDIR\${PRODUCT_EXENAME}"
SectionEnd



Section -AdditionalIcons
  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\${PRODUCT_EXENAME}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\${PRODUCT_EXENAME}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


Section Uninstall
  ${nsProcess::KillProcess} "Suar Snipping Tool.exe" $R0
  RMDir /r "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  
  DeleteRegKey HKCU "Software\SmartArab\Suar Snipping Tool"
  
  SetShellVarContext all
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk"
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk"
  Delete "$DESKTOP\${PRODUCT_NAME}.lnk"
  SetShellVarContext current
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\Uninstall.lnk"
  Delete "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk"
  Delete "$DESKTOP\${PRODUCT_NAME}.lnk"
  Delete "$SMPROGRAMS\Startup\${PRODUCT_NAME}.lnk"
SectionEnd
