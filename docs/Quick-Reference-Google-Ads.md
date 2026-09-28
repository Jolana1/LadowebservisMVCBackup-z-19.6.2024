# Quick Reference - Google Ads Configuration

## 🚀 Quick Start (5 Minutes)

### Step 1: Get Your IDs (2 min)
```
1. Go to: https://ads.google.com
2. Click: Tools (🔧) → Conversions
3. Click: + New conversion action
4. Select: Website → Purchase
5. Copy: Conversion ID & Label
```

### Step 2: Update Code (2 min)
```
File: LadowebservisMVC\Views\Shared\_Layout.cshtml

Line ~27: gtag('config', 'AW-YOUR-ID-HERE');
Line ~32: 'send_to': 'AW-YOUR-ID-HERE/YOUR-LABEL-HERE',
```

### Step 3: Test (1 min)
```
1. Place test order
2. Press F12 → Console tab
3. Look for: "Google Ads conversion tracked..."
4. ✅ Done!
```

---

## 📊 Example Configuration

### Your IDs will look like this:
```javascript
// Example only - use YOUR actual IDs
gtag('config', 'AW-1234567890');

gtag('event', 'conversion', {
	'send_to': 'AW-1234567890/AbC1D2eFgH3IjKlM4nO',
	'transaction_id': 'ORD-20250121-001',
	'value': 125.50,
	'currency': 'EUR'
});
```

---

## 🎯 What Gets Tracked

### Automatically Tracked:
✅ Order Placed (Purchase conversion)  
✅ Order Value (in EUR)  
✅ Transaction ID (unique order number)  
✅ Success/Failure status

### Available Data:
- Conversion rate by campaign
- Revenue per conversion
- Cost per acquisition (CPA)
- Return on ad spend (ROAS)

---

## 🔧 Code Locations

| What | File | Line |
|------|------|------|
| Google Ads Tag | `_Layout.cshtml` | ~23-40 |
| Conversion Function | `_Layout.cshtml` | ~30-36 |
| Tracking Call | `OdoslanaObjednavka.cshtml` | ~250-265 |
| Product Images | `ProductCatalog.cs` | ~18-24 |

---

## ✅ Testing Checklist

- [ ] Replaced `AW-XXXXXXXXXX` with actual Conversion ID
- [ ] Replaced `CONVERSION_LABEL` with actual label
- [ ] Placed test order
- [ ] Checked browser console for tracking message
- [ ] Verified request in Network tab
- [ ] Checked Google Ads for test conversion (wait 24h)

---

## 🎨 Customizing IT Service Images

### Current Setup:
```csharp
// LadowebservisMVC\Util\ProductCatalog.cs
{ "100", new ProductInfo { 
	Name = "Tvorba webovej stránky",
	Image = "/Image/LWSlogo.webp",  // ← Change here
	Price = 299.00m 
}}
```

### To Use Custom Images:
1. Add image to: `LadowebservisMVC\Image\`
2. Recommended: 400x400px, PNG/WebP
3. Update Image path in ProductCatalog.cs
4. Rebuild solution

---

## 🐛 Troubleshooting

### Conversions Not Showing?
```
✓ Wait 24-48 hours for data
✓ Check browser console for errors
✓ Verify IDs match exactly
✓ Ensure cookies enabled
✓ Check ad blockers disabled during test
```

### Images Not Loading?
```
✓ Verify file exists in /Image folder
✓ Check file name matches exactly (case-sensitive)
✓ Clear browser cache (Ctrl+F5)
✓ Check file path starts with /Image/
```

---

## 📱 Contact & Support

**Google Ads Support:**  
https://support.google.com/google-ads/gethelp

**Test Conversion Tracking:**  
https://support.google.com/google-ads/answer/6095947

**Tag Assistant (Chrome Extension):**  
https://tagassistant.google.com/

---

## 💰 ROI Calculation

```
Example Campaign:
├─ Ad Spend: €200
├─ Conversions: 5 orders
├─ Revenue: €750
└─ ROAS: 3.75x (€750 ÷ €200)

Good ROAS: > 2.0x
Great ROAS: > 4.0x
```

---

## 🎯 Campaign Ideas

### Health Products:
- "Balance Oil Košice" (local targeting)
- "Zinzino Slovensko" (brand awareness)
- "Omega-3 test" (product-focused)

### IT Services:
- "tvorba webstránok Košice" (local)
- "webdizajn na mieru" (service)
- "IT poradenstvo" (consulting)

### Keywords to Avoid:
❌ Too broad: "health", "IT"  
❌ Too competitive: "omega 3", "web design"  
✅ Focus on: Local + Specific service + Slovak language

---

**Last Updated:** January 2025  
**Need Help?** Check `docs\Google-Ads-Setup-Instructions.md` for detailed guide
