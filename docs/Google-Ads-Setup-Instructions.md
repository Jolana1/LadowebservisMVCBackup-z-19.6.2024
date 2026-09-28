# Google Ads Conversion Tracking Setup Instructions

## Overview
Google Ads conversion tracking has been integrated into your Ladowebservis website to track purchases and measure the effectiveness of your advertising campaigns.

## Configuration Steps

### 1. Get Your Google Ads IDs
1. Sign in to your Google Ads account at https://ads.google.com
2. Click on **Tools & Settings** (wrench icon) → **Measurement** → **Conversions**
3. Create a new conversion action if you haven't already:
   - Click the **+ New conversion action** button
   - Select **Website**
   - Category: **Purchase**
   - Value: Use transaction-specific values
   - Count: Every conversion
4. After creating, you'll see:
   - **Conversion ID** (format: AW-XXXXXXXXXX)
   - **Conversion Label** (unique string for this conversion action)

### 2. Update Your Website Code

Open `LadowebservisMVC\Views\Shared\_Layout.cshtml` and replace the placeholders:

**Line ~26-28:** Replace `AW-XXXXXXXXXX` with your actual Conversion ID:
```javascript
gtag('config', 'AW-1234567890'); // Replace with YOUR Conversion ID
```

**Line ~32:** Replace both placeholders:
```javascript
'send_to': 'AW-1234567890/AbC1D2eFgH3IjKlM4nO', // Replace with YOUR conversion ID/label
```

### 3. Where Tracking Happens

The conversion tracking fires automatically on the order confirmation page when:
- A customer successfully places an order
- The order has a valid order number and total amount
- They land on `/Home/PlaceOrder` (OdoslanaObjednavka.cshtml)

### 4. Test Your Setup

1. **Test Mode:**
   - Place a test order on your website
   - Open browser developer tools (F12)
   - Check the Console tab for: `Google Ads conversion tracked: Order #...`
   - Check the Network tab for requests to `googletagmanager.com`

2. **Google Ads Verification:**
   - Go to Google Ads → Tools → Conversions
   - Check the "Status" column - it should show "Recording conversions"
   - Within 24-48 hours, you should see test conversions appear

### 5. Enhanced Tracking (Optional)

For better conversion attribution, you can also track:
- **Add to Cart events** - Track when users add products
- **Begin Checkout** - Track when users start checkout
- **Purchase Intent** - Track users who view cart page

## IT Service Product Images

The IT service products now use the following images from your Image folder:
- **Tvorba webovej stránky**: `/Image/LWSlogo.webp`
- **E-shop na mieru**: `/Image/LWSlogo 2.webp`
- **Oprava PC/notebooku**: `/Image/LWSlogo 3.webp`
- **Inštalácia softvéru**: `/Image/LWSlogo 4.webp`
- **IT poradenstvo**: `/Image/LWSlogo 5.webp`
- **Hosting**: `/Image/LWSlogo 6.webp`

### Customizing IT Service Images

To use different images:
1. Add your image files to `LadowebservisMVC\Image\` folder
2. Update `LadowebservisMVC\Util\ProductCatalog.cs`
3. Change the `Image` property for products with IDs 100-105

Example:
```csharp
{ "100", new ProductInfo { 
	Id = "100", 
	Name = "Tvorba webovej stránky", 
	Price = 299.00m, 
	Image = "/Image/your-custom-image.png", // Update this
	Stock = 999 
} },
```

## Files Modified

1. **_Layout.cshtml** - Added Google Ads global site tag and conversion function
2. **OdoslanaObjednavka.cshtml** - Added conversion tracking script on order success
3. **ProductCatalog.cs** - Updated IT service product images to use existing LWSlogo variants

## Support

For questions about:
- **Google Ads setup**: https://support.google.com/google-ads/answer/6331304
- **Conversion tracking troubleshooting**: https://support.google.com/google-ads/answer/6095947
- **Website integration**: Contact your web developer

## Privacy & GDPR Compliance

✅ The site already has:
- Cookie consent banner (TermsFeed)
- Privacy policy link in footer
- User consent before tracking

Make sure your privacy policy mentions Google Ads tracking and provides opt-out information.
