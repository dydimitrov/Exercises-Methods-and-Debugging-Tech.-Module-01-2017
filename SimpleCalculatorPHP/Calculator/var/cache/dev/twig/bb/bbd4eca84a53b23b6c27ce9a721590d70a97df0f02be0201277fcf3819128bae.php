<?php

/* base.html.twig */
class __TwigTemplate_7070b1e896991ca0ec76e41a22190053a00d28a76827f47c89acec5dd9afd07c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_5c871c79c35e0130215a04fdd4e515009c931bd90270ff84f30eea473ad782e1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5c871c79c35e0130215a04fdd4e515009c931bd90270ff84f30eea473ad782e1->enter($__internal_5c871c79c35e0130215a04fdd4e515009c931bd90270ff84f30eea473ad782e1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_5c871c79c35e0130215a04fdd4e515009c931bd90270ff84f30eea473ad782e1->leave($__internal_5c871c79c35e0130215a04fdd4e515009c931bd90270ff84f30eea473ad782e1_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_37df225fe632cdf46099538e66a0125af85342b2c9a99c71d2e9b344daa38996 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_37df225fe632cdf46099538e66a0125af85342b2c9a99c71d2e9b344daa38996->enter($__internal_37df225fe632cdf46099538e66a0125af85342b2c9a99c71d2e9b344daa38996_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_37df225fe632cdf46099538e66a0125af85342b2c9a99c71d2e9b344daa38996->leave($__internal_37df225fe632cdf46099538e66a0125af85342b2c9a99c71d2e9b344daa38996_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_d5d7077cab35920af1a9f4c0a20db251703488bdea7da070d0512f592387df9f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d5d7077cab35920af1a9f4c0a20db251703488bdea7da070d0512f592387df9f->enter($__internal_d5d7077cab35920af1a9f4c0a20db251703488bdea7da070d0512f592387df9f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_d5d7077cab35920af1a9f4c0a20db251703488bdea7da070d0512f592387df9f->leave($__internal_d5d7077cab35920af1a9f4c0a20db251703488bdea7da070d0512f592387df9f_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_58498f4b13a3b13dca6278945f0d59b000c901b57ca1bf347568c28fd97bb215 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_58498f4b13a3b13dca6278945f0d59b000c901b57ca1bf347568c28fd97bb215->enter($__internal_58498f4b13a3b13dca6278945f0d59b000c901b57ca1bf347568c28fd97bb215_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_58498f4b13a3b13dca6278945f0d59b000c901b57ca1bf347568c28fd97bb215->leave($__internal_58498f4b13a3b13dca6278945f0d59b000c901b57ca1bf347568c28fd97bb215_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_b10dc305046f66c3fc046a2383afe12d89933037acd111f2a3c30b9cb2966035 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b10dc305046f66c3fc046a2383afe12d89933037acd111f2a3c30b9cb2966035->enter($__internal_b10dc305046f66c3fc046a2383afe12d89933037acd111f2a3c30b9cb2966035_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_b10dc305046f66c3fc046a2383afe12d89933037acd111f2a3c30b9cb2966035->leave($__internal_b10dc305046f66c3fc046a2383afe12d89933037acd111f2a3c30b9cb2966035_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_933c3b449154d90c8b971258ab725188352f139bea6949124377fc3a44a6ebe7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_933c3b449154d90c8b971258ab725188352f139bea6949124377fc3a44a6ebe7->enter($__internal_933c3b449154d90c8b971258ab725188352f139bea6949124377fc3a44a6ebe7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_933c3b449154d90c8b971258ab725188352f139bea6949124377fc3a44a6ebe7->leave($__internal_933c3b449154d90c8b971258ab725188352f139bea6949124377fc3a44a6ebe7_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_282431e119049e2d53a1c5ff062fc004840f3a6b3216b275ec5298310cfabbf4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_282431e119049e2d53a1c5ff062fc004840f3a6b3216b275ec5298310cfabbf4->enter($__internal_282431e119049e2d53a1c5ff062fc004840f3a6b3216b275ec5298310cfabbf4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_282431e119049e2d53a1c5ff062fc004840f3a6b3216b275ec5298310cfabbf4->leave($__internal_282431e119049e2d53a1c5ff062fc004840f3a6b3216b275ec5298310cfabbf4_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_8a5ae2160c50488511327698b879af8e455d769bf0f7829a2e4b9efe11e582e3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8a5ae2160c50488511327698b879af8e455d769bf0f7829a2e4b9efe11e582e3->enter($__internal_8a5ae2160c50488511327698b879af8e455d769bf0f7829a2e4b9efe11e582e3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_8a5ae2160c50488511327698b879af8e455d769bf0f7829a2e4b9efe11e582e3->leave($__internal_8a5ae2160c50488511327698b879af8e455d769bf0f7829a2e4b9efe11e582e3_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
