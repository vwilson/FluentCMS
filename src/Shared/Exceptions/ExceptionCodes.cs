﻿namespace FluentCMS;

public static class ExceptionCodes
{
    #region Setup

    public const string SetupSettingsNotDefined = "SetupSettings.NotDefined";
    public const string SetupSettingsNotInitialized = "SetupSettings.NotInitialized";
    public const string SetupSettingsAlreadyInitialized = "SetupSettings.AlreadyInitialized";
    public const string SetupSettingsHostingEnvironmentIsNull = "SetupSettings.HostingEnvironmentIsNull";

    #endregion

    #region GlobalSettings

    public const string GlobalSettingsUnableToUpdate = "GlobalSettings.UnableToUpdate";
    public const string GlobalSettingsUnableToInit = "GlobalSettings.UnableToInit";
    public const string GlobalSettingsNotFound = "GlobalSettings.NotFound";

    #endregion

    #region User

    public const string UserNotFound = "User.NotFound";
    public const string UserLoginFailed = "User.LoginFailed";
    public const string UserChangePasswordFailed = "User.ChangePasswordFailed";
    public const string UserTokenGenerationFailed = "User.TokenGenerationFailed";

    #endregion

    #region App

    public const string AppNotFound = "App.NotFound";
    public const string AppSlugNotUnique = "App.SlugNotUnique";
    public const string AppUnableToCreate = "App.UnableToCreate";
    public const string AppUnableToUpdate = "App.UnableToUpdate";
    public const string AppUnableToDelete = "App.UnableToDelete";

    #endregion

    #region Role


    public const string RoleUnableToCreate = "Role.UnableToCreate";
    public const string RoleUnableToUpdate = "Role.UnableToUpdate";
    public const string RoleUnableToDelete = "Role.UnableToDelete";
    public const string RoleNotFound = "Role.NotFound";
    public const string RoleNameMustBeUnique = "Role.NameMustBeUnique";
    public const string RoleInvalidAppId = "Role.InvalidAppId";

    #endregion

    #region Content
    public const string ContentUnableToCreate = "Content.UnableToCreate";
    public const string ContentUnableToUpdate = "Content.UnableToUpdate";
    public const string ContentUnableToDelete = "Content.UnableToDelete";
    public const string ContentNotFound = "Content.NotFound";
    public const string ContentTypeMismatch = "Content.TypeMismatch";
    public const string ContentAppIdMismatch = "Content.AppIdMismatch";
    #endregion

    #region ContentType

    public const string ContentTypeUnableToCreate = "ContentType.UnableToCreate";
    public const string ContentTypeUnableToUpdate = "ContentType.UnableToUpdate";
    public const string ContentTypeUnableToDelete = "ContentType.UnableToDelete";
    public const string ContentTypeNotFound = "ContentType.NotFound";
    public const string ContentTypeNameCannotBeChanged = "ContentType.NameCannotBeChanged";
    public const string ContentTypeNameMustBeUnique = "ContentType.NameMustBeUnique";
    public const string ContentTypeFieldNotFound = "ContentType.FieldNotFound";
    public const string ContentTypeInvalidAppId = "ContentType.InvalidAppId";
    public const string ContentTypeDuplicateSlug = "ContentType.DuplicateSlug";

    #endregion

    #region Plugin

    public const string PluginUnableToCreate = "Plugin.UnableToCreate";
    public const string PluginUnableToUpdate = "Plugin.UnableToUpdate";
    public const string PluginUnableToDelete = "Plugin.UnableToDelete";
    public const string PluginNotFound = "Plugin.NotFound";

    #endregion

    #region PluginDefinition

    public const string PluginDefinitionUnableToCreate = "PluginDefinition.UnableToCreate";
    public const string PluginDefinitionUnableToUpdate = "PluginDefinition.UnableToUpdate";
    public const string PluginDefinitionUnableToDelete = "PluginDefinition.UnableToDelete";
    public const string PluginDefinitionNotFound = "PluginDefinition.NotFound";

    #endregion


    #region Asset (File/Folder)

    public const string FolderUnableToCreate = "Folder.UnableToCreate";
    public const string FolderParentFolderNotFound = "Folder.ParentFolderNotFound";
    public const string FolderNotFound = "Folder.NotFound";
    public const string FolderUnableToUpdate = "Folder.UnableToUpdate";
    public const string FolderUnableToDelete = "Folder.UnableToDelete";

    public const string FileNotFound = "File.NotFound";
    public const string FileUnableToDelete = "File.UnableToDelete";
    public const string FileUnableToCreate = "File.UnableToCreate";
    public const string FileUnableToUpdate = "File.UnableToUpdate";

    #endregion

    #region Layout

    public const string LayoutUnableToCreate = "Layout.UnableToCreate";
    public const string LayoutUnableToUpdate = "Layout.UnableToUpdate";
    public const string LayoutUnableToDelete = "Layout.UnableToDelete";
    public const string LayoutNotFound = "Layout.NotFound";

    #endregion

    #region Site

    public const string SiteNotFound = "Site.NotFound";
    public const string SiteUrlMustBeUnique = "Site.UrlMustBeUnique";
    public const string SiteUnableToCreate = "Site.UnableToCreate";
    public const string SiteUnableToUpdate = "Site.UnableToUpdate";
    public const string SiteUnableToDelete = "Site.UnableToDelete";

    #endregion

    #region Page

    public const string PageUnableToCreate = "Page.UnableToCreate";
    public const string PageUnableToUpdate = "Page.UnableToUpdate";
    public const string PageUnableToDelete = "Page.UnableToDelete";
    public const string PagePathMustBeUnique = "Page.PathMustBeUnique";
    public const string PageNotFound = "Page.NotFound";
    public const string PageParentPageNotFound = "Page.ParentPageNotFound";
    public const string PageParentMustBeOnTheSameSite = "Page.ParentMustBeOnTheSameSite";
    public const string PageViewPermissionsAreNotASubsetOfParent = "Page.ViewPermissionsAreNotASubsetOfParent";
    public const string PageSiteIdCannotBeChanged = "Page.SiteIdCannotBeChanged";
    public const string PageHasChildren = "Page.PageHasChildren";

    #endregion

    #region API Token

    public const string ApiTokenUnableToCreate = "ApiToken.UnableToCreate";
    public const string ApiTokenNotFound = "ApiToken.NotFound";
    public const string ApiTokenExpired = "ApiToken.Expired";
    public const string ApiTokenInactive = "ApiToken.Inactive";
    public const string ApiTokenInvalidSecret = "ApiToken.InvalidSecret";
    public const string ApiTokenUnableToUpdate = "ApiToken.UnableToUpdate";
    public const string ApiTokenUnableToDelete = "ApiToken.UnableToDelete";

    #endregion

    #region PluginContent

    public const string PluginContentUnableToCreate = "PluginContent.UnableToCreate";
    public const string PluginContentUnableToUpdate = "PluginContent.UnableToUpdate";
    public const string PluginContentUnableToDelete = "PluginContent.UnableToDelete";
    public const string PluginContentNotFound = "PluginContent.NotFound";

    #endregion
}
