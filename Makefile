build_docker: clean
	docker build . -t oroszgy/lemmagen3

clean:
	find . -type d | grep -E "/(obj|bin)$$" | xargs rm -rf

build:
	xbuild ./LemmaSharpPrebuiltFull.sln
