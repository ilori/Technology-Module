<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use SoftUniBlogBundle\Entity\Article;
use SoftUniBlogBundle\Entity\User;
use SoftUniBlogBundle\Form\ArticleType;
use SoftUniBlogBundle\Repository\ArticleRepository;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Routing\Annotation\Route;

class ArticleController extends Controller
{
    /** @Route("/articles/create", name="article_create")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
    return \Symphony\Component\HttpFoundation\Response
     */
    public function create(Request $request)
    {
        $article = new Article();
        $form = $this->createForm(ArticleType::class, $article);
        $form->handleRequest($request);

        $loggedUser = $this->getUser();
        if ($form->isValid()) {
            $article->setAuthor($loggedUser);
            $em = $this->getDoctrine()->getManager();
            $em->persist($article);
            $em->flush();

            return $this->redirectToRoute("article_list");
        }
        return $this->render('articles/create.html.twig', ['form' => $form->createView()]);
    }

    /**
     * @Route("/articles/list",name="article_list")
     * */
    public function ListArticles()
    {
        $repo = $this->getDoctrine()->getRepository(Article::class);
        $allArticles = $repo->findAll();
        return $this->render("/articles/list.html.twig", ['articles' => $allArticles]);
    }

    /**
     * @Route("/articles/mine",name="my_articles")
     * */
    public function myArticles()
    {
        $repo = $this->getDoctrine()->getRepository(Article::class);
        /** @var User $loggedUser */
        $loggedUser = $this->getUser();
        $allArticles = $loggedUser->getArticles();
        return $this->render("/articles/list.html.twig", ['articles' => $allArticles]);
    }

    /** @Route("/articles/{id}",name="show_article")
     * @param $id
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function showArticle($id)
    {
        $repo = $this->getDoctrine()->getRepository(Article::class);
        $article = $repo->find($id);

        return $this->render("articles/show.html.twig", ['article' => $article]);
    }
}
