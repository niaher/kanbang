﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kanbang.Web.Default" %>

<!DOCTYPE html>
<html lang="">
<head>
	<title>Kanbang</title>
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">

	<base href="/">

	<link rel="shortcut icon" href="favicon.png" />

	<!-- styles -->
	<link href='http://fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700' rel='stylesheet' type='text/css'>

	<link href="/css/main" rel="stylesheet" type="text/css">
	<!-- Angular 2 -->
	<script src="/client/public/lib/traceur-runtime.min.js"></script>
</head>
<body>

	<div class="container-fluid">
		<!--[if lte IE 8]>
			<p id="oldbrowser" class="alert alert-danger">You are using an <strong>outdated</strong> browser, which we do not support. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
		<![endif]-->

		<header>
			<nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
				<div class="col-sm-8">
					<div class="navbar-header">
						<button type="button" class="navbar-toggle pull-left visible-sm visible-xs btn-left-menu" ng-init="navCollapsed = true" ng-click="navCollapsed = !navCollapsed">
							<span class="sr-only">Toggle navigation</span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
						</button>
						<a class="navbar-brand" href="/">
							<img src="/Styles/Images/logo.png" class="logo" />
							Kanbang
						</a>
					</div>
				</div>

				<div class="col-sm-4 login hidden-xs">
					<span>@AppUser.DisplayName</span>
				</div>
			</nav>
		</header>

		<div class="row">
			<ol class="breadcrumb layout">
				<li><a href="/"><span class="fa fa-home"></span></a></li>
				<li>Kanbang</li>
				<!--@foreach (var link in this.Model)
				{
				<li itemscope itemtype="http://data-vocabulary.org/Breadcrumb">
					<a href="@link.Url" itemprop="url">
						<span itemprop="title">@Html.Raw(link.Anchor)</span>
					</a>
				</li>
				}

				<li itemscope itemtype="http://data-vocabulary.org/Breadcrumb" ng-repeat="link in breadcrumbs" class="ng-cloak">
					<a ng-href="{{link.url}}" itemprop="url">
						<span itemprop="title">{{link.anchor}}</span>
					</a>
				</li>-->
			</ol>
		</div>

		<div class="row">
			<div class="side-menu left col-sm-12 col-md-2" ng-class="{'closed':!!navCollapsed}" role="menu">
				<ul>
					<li class="side-menu-header">My stuff</li>
					<li><a href="#">My boards</a></li>
					<li class="side-menu-submenu">
						<a tabindex="-1" ng-click="menu1Show = !menu1Show">More options</a>
						<ul ng-show="menu1Show">
							<li><a href="#">Second level</a></li>
							<li class="side-menu-submenu">
								<a href="#" ng-click="menu2Show = !menu2Show">More..</a>
								<ul ng-show="menu2Show">
									<li><a href="#">3rd level</a></li>
									<li><a href="#">3rd level</a></li>
								</ul>
							</li>
							<li><a href="#">Second level</a></li>
							<li><a href="#">Second level</a></li>
						</ul>
					</li>
					<li class="side-menu-header">Adminstration</li>
					<li class="side-menu-header">Help</li>
					<li><a href="/swagger" target="_blank">Web API docs</a></li>
				</ul>
			</div>
			<div id="main-content">
				<app>Loading...</app>
			</div>
		</div>
	</div>
	
	<!-- Commmon files to be cached -->
	<script src="/client/public/__build__/common.js"></script>
	<!-- Angular2 files -->
	<script src="/client/public/__build__/angular2.js"></script>
	<!-- App script -->
	<script src="/client/public/__build__/app.js"></script>
</body>
</html>
