<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_7cb139da93b686be8e07e44880e1aaa98f2065502a714a056723653b416ad682 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_33b460d96062def44a4fb10a9ebf50200e8b074fd991befaec7aa11a9196d6fb = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_33b460d96062def44a4fb10a9ebf50200e8b074fd991befaec7aa11a9196d6fb->enter($__internal_33b460d96062def44a4fb10a9ebf50200e8b074fd991befaec7aa11a9196d6fb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_33b460d96062def44a4fb10a9ebf50200e8b074fd991befaec7aa11a9196d6fb->leave($__internal_33b460d96062def44a4fb10a9ebf50200e8b074fd991befaec7aa11a9196d6fb_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_f7b4ba123f7a1f7f3b946dfaac564e431e43216444709a178c17a1acebaeb556 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f7b4ba123f7a1f7f3b946dfaac564e431e43216444709a178c17a1acebaeb556->enter($__internal_f7b4ba123f7a1f7f3b946dfaac564e431e43216444709a178c17a1acebaeb556_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_f7b4ba123f7a1f7f3b946dfaac564e431e43216444709a178c17a1acebaeb556->leave($__internal_f7b4ba123f7a1f7f3b946dfaac564e431e43216444709a178c17a1acebaeb556_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_d712d1f1af4052c8faebc67d47df378948fe9bf6c701c78b568d6b5f83c3333e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d712d1f1af4052c8faebc67d47df378948fe9bf6c701c78b568d6b5f83c3333e->enter($__internal_d712d1f1af4052c8faebc67d47df378948fe9bf6c701c78b568d6b5f83c3333e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_d712d1f1af4052c8faebc67d47df378948fe9bf6c701c78b568d6b5f83c3333e->leave($__internal_d712d1f1af4052c8faebc67d47df378948fe9bf6c701c78b568d6b5f83c3333e_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_d5a19ff45fb3d0a745186acea4d3b3f632600730ae75e46bc3cb8d4b6057030e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d5a19ff45fb3d0a745186acea4d3b3f632600730ae75e46bc3cb8d4b6057030e->enter($__internal_d5a19ff45fb3d0a745186acea4d3b3f632600730ae75e46bc3cb8d4b6057030e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_d5a19ff45fb3d0a745186acea4d3b3f632600730ae75e46bc3cb8d4b6057030e->leave($__internal_d5a19ff45fb3d0a745186acea4d3b3f632600730ae75e46bc3cb8d4b6057030e_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
