<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_f16609bc2cfca10948ea2a1e8f5ce9d43db73f0d6ecebae996fec1703a27dd86 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d180018f9ddb851bb6adc617fd822a73ffc989236c13e7756dc8f388887fb207 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d180018f9ddb851bb6adc617fd822a73ffc989236c13e7756dc8f388887fb207->enter($__internal_d180018f9ddb851bb6adc617fd822a73ffc989236c13e7756dc8f388887fb207_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d180018f9ddb851bb6adc617fd822a73ffc989236c13e7756dc8f388887fb207->leave($__internal_d180018f9ddb851bb6adc617fd822a73ffc989236c13e7756dc8f388887fb207_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_a409c1f6c178b99b2867e9801fc140effb8dc9e55a8ab0727d561287dc78dc4e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a409c1f6c178b99b2867e9801fc140effb8dc9e55a8ab0727d561287dc78dc4e->enter($__internal_a409c1f6c178b99b2867e9801fc140effb8dc9e55a8ab0727d561287dc78dc4e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_a409c1f6c178b99b2867e9801fc140effb8dc9e55a8ab0727d561287dc78dc4e->leave($__internal_a409c1f6c178b99b2867e9801fc140effb8dc9e55a8ab0727d561287dc78dc4e_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_09f2fbc236566f23d2fb8dcba9a629bdf266263430e18de6420475c14f509dd6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_09f2fbc236566f23d2fb8dcba9a629bdf266263430e18de6420475c14f509dd6->enter($__internal_09f2fbc236566f23d2fb8dcba9a629bdf266263430e18de6420475c14f509dd6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_09f2fbc236566f23d2fb8dcba9a629bdf266263430e18de6420475c14f509dd6->leave($__internal_09f2fbc236566f23d2fb8dcba9a629bdf266263430e18de6420475c14f509dd6_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_727d4208e8b8843cabc263b8ddfd7339ceade8d0bfb2071b3bfe07679ef290d6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_727d4208e8b8843cabc263b8ddfd7339ceade8d0bfb2071b3bfe07679ef290d6->enter($__internal_727d4208e8b8843cabc263b8ddfd7339ceade8d0bfb2071b3bfe07679ef290d6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_727d4208e8b8843cabc263b8ddfd7339ceade8d0bfb2071b3bfe07679ef290d6->leave($__internal_727d4208e8b8843cabc263b8ddfd7339ceade8d0bfb2071b3bfe07679ef290d6_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
