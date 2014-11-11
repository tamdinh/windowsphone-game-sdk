<head>
<meta content="en-us" http-equiv="Content-Language" />
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<link href="../main.css" rel="stylesheet" type="text/css" />
<link href="../code.css" rel="stylesheet" type="text/css" />
<script src="../rainbow.min.js"></script>
</head>

<body>
<p class="class_title"><strong>WP8 payment SDK - Get Started</strong></p>

<p class="class_title"><strong>Get Started</strong></p>
<p>Windows Phone的Appota Payment SDK是在Appota系统给您的应用添加付费系统最简单的方式。这个SDK提供一下各种付费方式：短信、电话卡、网银和paypal Payment。</p>

<p class="auto-style1"><strong>添加SDK的步骤：</strong></p>
<p>1. 下载并且添加SDK reference</p>
<p>2. SDK配置</p>
<p>3. JSON配置</p>
<p>4. 添加</p>
<p>5. 运行SDK sample</p>
<p>&nbsp;</p>

<p class="auto-style1"><strong>1. 添加SDK reference</strong></p>

-	在项目的references添加付费数据库 <strong>APTPaymentService.dll</strong>
-	如果有PayPal付费格式，需要下载并且添加Paypal sdkPayPal.Checkout.SDK-WindowsPhone8
-	若果用twitter账号登录系统，需要添加两个数据库Hammock.WindowsPhone和ICSharpCode.SharpZipLib.WindowsPhone（这是Twitter sdk自定义文件夹）。

<p class="auto-style1"><strong>2. SDK配置</strong></p>

- •	在项目里打开WMAppManifest，转到Capabilities标签，选择ID-CAP-IDENTITY
- •	把AppotaConfig.xml文件添加到项目。这文件有SDK配置数据。
	
> - 从dev.appota.com采取key:

		<apiKey>Replace with your apiKey</apiKey>
		<apikeySandbox>Replace with your Sanbox ApiKey<apikeySandbox>
		<testSandbox>false</testSandbox>

	
> - Notify Url：付费成功时系统调用的地址

	 <notifyUrl>Replace with your notify Url</notifyUrl>
	
> - Config Url：json config文件的地址。看3. JSON配置

	<configUrl>http://appvn.com/payment-winphone.php</configUrl>

> - 如果需要用FB账号登陆，添加:

	 <facebookAppId>Replace with facebookAppId</facebookAppId>
  	 <facebookClientSecret>Replace with facebookClientSecret</facebookClientSecret>
	
> - 如果需要用谷歌账号登陆，添加:
 
	<googleClientID>Replace with googleClientID</googleClientID>
	<googleClientSecret>Replace with googleClientSecret</googleClientSecret>
	
> - 如果需要用Twitter账号登陆，添加:
 
	<twitterConsumerKey>Replace with twitterConsumerKey</twitterConsumerKey>
	<twitterConsumerKeySecret>Replace with twitterConsumerKeySecret</twitterConsumerKeySecret>
	

<p class="auto-style1"><strong>3. JSON配置</strong></p>

<p>Appota Game SDK给研发方提供一个简单方便多随变的配置方式。使用这方式，您需要进行一下的步骤</p>
- •	使用JSON Generator工具打造包含配置的JSON文件
 ([https://developer.appota.com/sdktool.php](https://developer.appota.com/sdktool.php "https://developer.appota.com/sdktool.php")).
- •	在一个可以进接的host上传JSON配置。
- •	在AppotaConfig.xml配置的<configUrl>标签添加json地址 <strong>AppotaConfig.xml</strong>

<p class="auto-style1"><strong>4. Tích hợp SDK</strong></p>

<p>开启： AppotaGameSDK gameSDK;</p>
<p>初起: gameSDK = new AppotaGameSDK(<a href="#AppotaSDKCallback">AppotaSDKCallback</a> _callBack);</p>
<p><img src="Document/Init_SDK.JPG"/></p>

<p>SDK支持的方式:</p>
	- gameSDK.ShowUserInfo(); // Show user info UI
	- gameSDK.MakePayment(); // Show payment UI
	- gameSDK.SwitchAccount(); // Switch between accounts
	- gameSDK.LogoutAccount(); // Logout account

<strong><a name="AppotaSDKCallback">AppotaSDKCallback</a></strong> 是接受从SDK传来的callback函数的界面 (interface)；比如LoginCallback或者PaymentCallback。

    public interface AppotaSDKCallback
    {
        void onPaymentSuccess(TransactionResult result);
        void onPaymentError(String message);

        void onUserLoginSuccess(UserLoginResult result);
        void onUserLoginError(string message);

        void onUserRegisterSuccess(UserLoginResult result);
        void onUserRegisterError(string message);
    }

<p class="auto-style1"><strong>5. Project SDK Sample</strong></p>

<p>详细看SKD附件里的sample code</p>
<p>SDK sample的一些截图：</p>
<p><img src="Document/1.png" width=230/>&nbsp;<img src="Document/2.png" width=230/>&nbsp;<img src="Document/3.png" width=230/></p>
<p><img src="Document/4.png" width=230/>&nbsp;<img src="Document/5.png" width=230/>&nbsp;<img src="Document/6.png" width=230/></p>



</body>

</html>
