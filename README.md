## Settings

* Add **com.onesignal** nuget package

* AndroidManifest

``` 
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android" package="{package name}" android:installLocation="auto">
  <uses-sdk android:minSdkVersion="15" />

  <permission android:name="{package name}.permission.C2D_MESSAGE" android:protectionLevel="signature" />
  <uses-permission android:name="{package name}.permission.C2D_MESSAGE" />

  <application android:label="DemoNotification.Android">
    <receiver android:name="com.onesignal.GcmBroadcastReceiver" android:permission="com.google.android.c2dm.permission.SEND">
      <intent-filter>
        <action android:name="com.google.android.c2dm.intent.RECEIVE" />
        <category android:name="com.onesignal.teste" />
      </intent-filter>
    </receiver>
  </application>

</manifest>

```


* Add this code in MainActivity after SetContentView

`OneSignal.Current.StartInit("OneSignalID").EndInit();`
