namespace MakeupProject;

using System;
using System.Collections.Generic;
using System.Linq;

class MakeupProduct
{
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public string SkinType { get; set; }
    public string Tips { get; set; }
}

class Program
{
    static List<MakeupProduct> products = new List<MakeupProduct>
    {
        new MakeupProduct {
            Name = "Haus Labs Foundation",
            Category = "Foundation",
            Description = "A medium coverage, weightless, and non-comedogenic foundation with a natural finish.",
            SkinType = "Dry, Normal",
            Tips = "Shake well and apply with a damp sponge for best results."
        },
        new MakeupProduct
        {
            Name = "Illia Serum Skin Tint",
            Category = "Skin Tint",
            Description = "A lightweight skin tint with added SPF, niacinamide for brightening, and hyaluronic acid for hydration.",
            SkinType = "Dry, Normal",
            Tips = "First apply to the back of your hand before using your finger to evenly distribute product across your face before following with a damp beauty blender."
            
        },
        new MakeupProduct
        {
            Name = "bareMinerals BAREPRO 24HR Skin Perfection Powder Foundation",
            Category = "Foundation",
            Description = "A full coverage matte foundation providing 24 hours of coverage.",
            SkinType = "Dry, Normal",
            Tips = "Use a brush starting in areas where you want the most coverage and blend outward."
        },
        new MakeupProduct {
            Name = "Hourglass Vanish Airbrush Concealer",
            Category = "Concealer",
            Description = "Full coverage, weightless, and waterproof concealer that stays put for 16 hours.",
            SkinType = "Combination",
            Tips = "Dab on blemishes and blend with your fingertip."
        },
        new MakeupProduct
        {
            Name = "Glossier Stretch Concealer",
            Category = "Concealer",
            Description = "Medium coverage, long-wearing, with a radiant finish.",
            SkinType = "Dry, Normal",
            Tips = "Warm up formula with your fingertip and apply in layers on your undereyes, blending out with a designated concealer brush."
        },
        new MakeupProduct
        {
            Name = "Bobbi Brown Skin Concealer Stick",
            Category = "Concealer",
            Description = "A medium coverage concealer in a stick formula good for long-wear and gives a natural finish.",
            SkinType = "Dry, Normal",
            Tips = "Layer on the concealer in necessary places and pat in gently with fingertip."
        },
        new MakeupProduct
        {
            Name = "Charlotte Tilbury Hollywood Contour Wand",
            Category = "Contour",
            Description = "A liquid contour wand perfect for blending over liquid or powder makeup.",
            SkinType = "Dry, Normal",
            Tips = "Sweep the wand underneath your cheekbone and line the bridge of your nose up to your brow."
        },
        new MakeupProduct
        {
            Name = "Make Up For Forever Artist Longwear Skin-fusing Contour Powder",
            Category = "Contour",
            Description = "A soft, pressed powder formula made for long-wear with a matte finish.",
            SkinType = "Dry, Normal",
            Tips = "Apply with a brush to the natural shadows of your face, always sweeping in an upward motion."
        },
        new MakeupProduct
        {
            Name = "Fenty Match Stix Matte Contour Skinstick",
            Category = "Contour",
            Description = "A lightweight and blendable cream contour with a wide shade range.",
            SkinType = "Dry, Combination",
            Tips = "Apply in areas where your face naturally has shadows and blend upwards."
        },
        new MakeupProduct
        {
            Name = "Merit Flush Balm Cream Blush",
            Category = "Blush",
            Description = "A light coverage stick blush formulated with vitamin E for nourishment and leaves a radiant finish.",
            SkinType = "Dry, Normal",
            Tips = "Swipe above your cheekbones and blend with either your fingertips or a damp sponge. Layer for added color."
        },
        new MakeupProduct
        {
            Name = "Saie SuperSuede Powder Blush",
            Category = "Blush",
            Description = "A lightweight and long-wearing powder blush that's non-comedogenic.",
            SkinType = "Dry, Normal",
            Tips = "Use a brush, gently tapping the excess of and sweep over the apples of the cheeks towards the temples."
        },
        new MakeupProduct
        {
            Name = "Rare Beauty Soft Pinch Liquid Blush",
            Category = "Blush",
            Description = "A weightless highly-pigmented blush that lasts for up to 12 hours.",
            SkinType = "Normal, Combination",
            Tips = "Apply above your cheekbones and blend upwards."
        }, 
        new MakeupProduct
        {
            Name = "Lancome Monsieur Big Waterproof Mascara",
            Category = "Mascara",
            Description = "A waterproof mascara that delivers high-volume for up to 24 hours.",
            SkinType = "N/A",
            Tips = "Wiggle the mascara wand side to side from the base of your lashes to the tip for best results."
        },
        new MakeupProduct
        {
            Name = "Tower 28 Beauty MakeWaves Lengthening + Volumizing Mascara",
            Category = "Mascara",
            Description = "A vegan mascara that volumizes, lengthens, and defines your lashes effortlessly.",
            SkinType = "N/A",
            Tips = "Use the inner wave to create volume and the longer outer wave to lengthen and define lashes."
        },
        new MakeupProduct
        {
            Name = "Merit Clean Lash Lengthening Tubing Mascara",
            Category = "Mascara",
            Description = "A mascara made for everyday that defines, lengthens and separates your lashes with zero smudging.",
            SkinType = "N/A",
            Tips = "Comb through lashes gently, and wait between layers to dry for added volume."
        },
        new MakeupProduct
        {
            Name = "Makeup By Maro SuperSatin Lipstick",
            Category = "Lip Product",
            Description = "A creamy lipstick matte lipstick with a soft sheen",
            SkinType = "N/A",
            Tips = "Exfoliate lips before application for fuller, more lifted lips."
        },
        new MakeupProduct
        {
            Name = "Clarins Lip Comfort Hydrating Oil",
            Category = "Lip Product",
            Description = "A combination of unique oils designed for the nourishment, hydration and protection of your lips. ",
            SkinType = "N/A",
            Tips = "Apply directly with the applicator, reapplying as needed."
        },
        new MakeupProduct
        {
            Name = "Tarte Maracuja Juicy Lip Plumping Gloss",
            Category = "Lip Product",
            Description = "A hydrating plumping gloss treatment with buildable coverage and a glossy finish.",
            SkinType = "N/A",
            Tips = "Click once for the perfect amount of product for application and layer for perfect color"
        },
        new MakeupProduct
        {
            Name = "Huda Beauty Icy Nude",
            Category = "Eyeshadow Palette",
            Description = "18 ultra-pigmented shadows including a few slack formulas to ensure long-wear and a strong base.",
            SkinType = "N/A",
            Tips = "Use your finger to blend the shimmer on the inner 1/3 of your eyelid."
        },
        new MakeupProduct
        {
            Name = "Too Faced Natural Eyes",
            Category = "Eyeshadow Palette",
            Description = "A pigmented palette with a natural shade selection for any day or night look.",
            SkinType = "N/A",
            Tips = "Blend the lighter brown shades below the brow bone and pack the lightest shade on the eyelid for a natural look."
        },
        new MakeupProduct
        {
            Name = "Anastasia Beverly Hills Sugar Mini Eyeshadow palette",
            Category = "Eyeshadow Palette",
            Description = "9 colorful shades ranging from soft neutrals to bright and sparkly shades.",
            SkinType = "N/A",
            Tips = "Use the sparkly shades as a highlighter to bring together your whole look."
        },
        new MakeupProduct
        {
            Name = "NYX The Brow Glue Laminating Setting Gel",
            Category = "Brows",
            Description = "A 16 hour hold brow lamination that is nonsticky, transparent, and 100% waterproof.",
            SkinType = "N/A",
            Tips = "Use a dry spoolie to brush brows and the brow gel to shape them." 
        },
        new MakeupProduct
        {
            Name = "Anastasia Beverly Hills Dual-End Cream to Powder Brow",
            Category = "Brows",
            Description = "A soft-powderlike formula that goes on smoothly, gliding easily through your natural brows.",
            SkinType = "N/A",
            Tips = "Follow up with a brow gel to lock the color in place."
        },
        new MakeupProduct
        {
            Name = "e.l.f. Clear Brow and Lash Mascara",
            Category = "Brows",
            Description = "Infused with vitamins B and E for nourishment, hold both brows and lashes in place.",
            SkinType = "N/A",
            Tips = "Work from the root of your brows and work outwards for best results."
        },
        new MakeupProduct
        {
            Name = "Hourglass Vanish Airbrush Pressed Powder",
            Category = "Setting Product",
            Description = "A long-wearing pressed powder formula that works to blur pores giving a matte finish.",
            SkinType = "Oily, Combination",
            Tips = "Apply with a powderpuff in areas where your face naturally becomes oily."
        },
        new MakeupProduct
        {
            Name = "Laura Mercier Translucent Loose Longwear Setting Powder",
            Category = "Setting Product",
            Description = "A loose powder formula with a matte finish that blends effortlessly into your makeup.",
            SkinType = "Dry, Normal",
            Tips = "Use a small fluffy brush to dust under eyes to set makeup."
        },
        new MakeupProduct
        {
            Name = "Urban Decay All-Nighter Waterproof Setting Spray",
            Category = "Setting Product",
            Description = "A waterproof setting spray that's holds and is transfer-proof for up to 16 hours.",
            SkinType = "Any",
            Tips = "Apply after foundation and at the end of your routine to lock your makeup in."
        }
    };

    static List<MakeupProduct> routine = new List<MakeupProduct>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Makeup Routine Builder!");
        
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Learn about a product");
            Console.WriteLine("2. Add a product to your routine");
            Console.WriteLine("3. View your routine");
            Console.WriteLine("4. Filter products by category");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    LearnAboutProduct();
                    break;
                case "2":
                    AddToRoutine();
                    break;
                case "3":
                    ViewRoutine();
                    break;
                case "4":
                    FilterByCategory();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void LearnAboutProduct()
    {
        Console.Write("Enter product name to learn about: ");
        string name = Console.ReadLine();

        var product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product != null)
        {
            Console.WriteLine($"\n{product.Name} ({product.Category})");
            Console.WriteLine($"Skin Type: {product.SkinType}");
            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine($"Tips: {product.Tips}\n");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    static void AddToRoutine()
    {
        Console.Write("Enter product name to add to routine: ");
        string name = Console.ReadLine();

        var product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product != null)
        {
            routine.Add(product);
            Console.WriteLine($"{product.Name} added to your routine.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
    static void FilterByCategory()
    {
        Console.Write("Enter a category (e.g., Foundation, Blush, Concealer): ");
        string category = Console.ReadLine();
        var filtered = products
            .Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (filtered.Count == 0)
        {
            Console.WriteLine($"No products found in the '{category}' category.");
            return;
        }

        Console.WriteLine($"\nProducts in the '{category}' category:");
        foreach (var product in filtered)
        {
            Console.WriteLine($"- {product.Name}: {product.Description}");
        }
    }

    static void ViewRoutine()
    {
        if (routine.Count == 0)
        {
            Console.WriteLine("Your routine is currently empty.");
            return;
        }

        Console.WriteLine("\nYour Routine:");
        foreach (var product in routine)
        {
            Console.WriteLine($"- {product.Category}: {product.Name}");
        }
    }
}
