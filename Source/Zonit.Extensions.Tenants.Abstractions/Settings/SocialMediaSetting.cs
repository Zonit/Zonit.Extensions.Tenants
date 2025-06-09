using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Zonit.Extensions.Tenants.Abstractions.Settings;

namespace Zonit.Extensions.Tenants;

/// <summary>
/// Represents a setting for storing links to social media profiles.
/// </summary>
public class SocialMediaSetting : Setting<SocialMediaModel>
{
    public override string Key => "social_media";
    public override string Name => "Social Media";
    public override string Description => "Links to social media profiles";
}

/// <summary>
/// Represents links to various social media profiles and platforms.
/// Each link will be available under the address: domain/facebook, domain/x, domain/instagram, domain/linkedin, etc.
/// </summary>
public class SocialMediaModel
{
    /// <summary>
    /// Link to the Facebook profile.
    /// The link will be available under the address: domain/facebook
    /// </summary>
    [Display(Name = "Facebook", Description = "Link to the Facebook profile. The link will be available under the address: domain/facebook")]
    [StringLength(200, ErrorMessage = "The Facebook link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Facebook link must be a valid URL.")]
    public string? Facebook { get; set; }

    /// <summary>
    /// Link to the X (formerly Twitter) profile.
    /// The link will be available under the address: domain/x
    /// </summary>
    [Display(Name = "X (formerly Twitter)", Description = "Link to the X (formerly Twitter) profile. The link will be available under the address: domain/x")]
    [StringLength(200, ErrorMessage = "The X link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The X link must be a valid URL.")]
    public string? X { get; set; }

    /// <summary>
    /// Link to the Instagram profile.
    /// The link will be available under the address: domain/instagram
    /// </summary>
    [Display(Name = "Instagram", Description = "Link to the Instagram profile. The link will be available under the address: domain/instagram")]
    [StringLength(200, ErrorMessage = "The Instagram link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Instagram link must be a valid URL.")]
    public string? Instagram { get; set; }

    /// <summary>
    /// Link to the LinkedIn profile.
    /// The link will be available under the address: domain/linkedin
    /// </summary>
    [Display(Name = "LinkedIn", Description = "Link to the LinkedIn profile. The link will be available under the address: domain/linkedin")]
    [StringLength(200, ErrorMessage = "The LinkedIn link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The LinkedIn link must be a valid URL.")]
    public string? LinkedIn { get; set; }

    /// <summary>
    /// Link to the YouTube channel.
    /// The link will be available under the address: domain/youtube
    /// </summary>
    [Display(Name = "YouTube", Description = "Link to the YouTube channel. The link will be available under the address: domain/youtube")]
    [StringLength(200, ErrorMessage = "The YouTube link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The YouTube link must be a valid URL.")]
    public string? YouTube { get; set; }

    /// <summary>
    /// Link to the TikTok profile.
    /// The link will be available under the address: domain/tiktok
    /// </summary>
    [Display(Name = "TikTok", Description = "Link to the TikTok profile. The link will be available under the address: domain/tiktok")]
    [StringLength(200, ErrorMessage = "The TikTok link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The TikTok link must be a valid URL.")]
    public string? TikTok { get; set; }

    /// <summary>
    /// Link to the Pinterest profile.
    /// The link will be available under the address: domain/pinterest
    /// </summary>
    [Display(Name = "Pinterest", Description = "Link to the Pinterest profile. The link will be available under the address: domain/pinterest")]
    [StringLength(200, ErrorMessage = "The Pinterest link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Pinterest link must be a valid URL.")]
    public string? Pinterest { get; set; }

    /// <summary>
    /// Link to the Snapchat profile.
    /// The link will be available under the address: domain/snapchat
    /// </summary>
    [Display(Name = "Snapchat", Description = "Link to the Snapchat profile. The link will be available under the address: domain/snapchat")]
    [StringLength(200, ErrorMessage = "The Snapchat link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Snapchat link must be a valid URL.")]
    public string? Snapchat { get; set; }

    /// <summary>
    /// Link to the Reddit profile or subreddit.
    /// The link will be available under the address: domain/reddit
    /// </summary>
    [Display(Name = "Reddit", Description = "Link to the Reddit profile or subreddit. The link will be available under the address: domain/reddit")]
    [StringLength(200, ErrorMessage = "The Reddit link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Reddit link must be a valid URL.")]
    public string? Reddit { get; set; }

    /// <summary>
    /// Link to the Twitch channel.
    /// The link will be available under the address: domain/twitch
    /// </summary>
    [Display(Name = "Twitch", Description = "Link to the Twitch channel. The link will be available under the address: domain/twitch")]
    [StringLength(200, ErrorMessage = "The Twitch link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Twitch link must be a valid URL.")]
    public string? Twitch { get; set; }

    /// <summary>
    /// Link to the Threads profile.
    /// The link will be available under the address: domain/threads
    /// </summary>
    [Display(Name = "Threads", Description = "Link to the Threads profile. The link will be available under the address: domain/threads")]
    [StringLength(200, ErrorMessage = "The Threads link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Threads link must be a valid URL.")]
    public string? Threads { get; set; }

    /// <summary>
    /// Invite link to the Discord server.
    /// The link will be available under the address: domain/discord
    /// </summary>
    [Display(Name = "Discord", Description = "Invite link to the Discord server. The link will be available under the address: domain/discord")]
    [StringLength(200, ErrorMessage = "The Discord link must be at most 200 characters long.")]
    [Url(ErrorMessage = "The Discord link must be a valid URL.")]
    public string? Discord { get; set; }
}